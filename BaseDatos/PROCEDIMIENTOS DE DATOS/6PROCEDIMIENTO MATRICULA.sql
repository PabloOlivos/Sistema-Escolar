-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA MATRICULA <<<<<<<-----------
-------------------------------------------------------------------------------------------

----Procedimiento para registrar una matricula-------
create procedure registrarMatricula(
@fechaMatricula date,
@codigoGrado int,
@numAlumno char(8), 
@numeroAnno int ,
@codigoSeccion int,
@nivelAlumno  varchar(20),
@eliminacionLogica bit
)
as
begin
insert into matricula values (@fechaMatricula, @codigoGrado, @numAlumno, @numeroAnno, @codigoSeccion, @nivelAlumno,@eliminacionLogica ) 
end 
GO
------fin del procedimiento almacenado Registrar matricula--------------

-------Procedimiento para actualizar una matricula---------------
 create procedure actualizarMatricula(
@idMatricula int ,
@fechaMatricula date ,
@codigoGrado int, 
@numAlumno char(8), 
@numeroAnno int, 
@codigoSeccion varchar(30),
@nivelAlumno  varchar(20),
@eliminacionLogica bit
)
as 
begin 
update Matricula set fechaMatricula = @FechaMatricula, codigoGrado = @codigoGrado, numAlumno = @numAlumno, numeroAnno = @numeroAnno, codigoSeccion = @codigoSeccion, nivelAlumno = @nivelAlumno,eliminacionLogica=@eliminacionLogica
where @idMatricula = idMatricula
end 
GO
------Fin del procedimiento almacenado Actualizar Matricula-----------

------Procedimiento almacenado para eliminar una matricula----------
create procedure eliminarMatricula(
@idMatricula int )
as
begin 
update Matricula set eliminacionLogica=1  where idMatricula = @idMatricula 
end
GO
------Fin del procedimiento almacenado eliminar-----

--Creamos procedimiento almacenado para obtener los datos de la tabla matricula
create procedure obtenerTablaMatricula
as 
begin
SELECT dbo.matricula.idMatricula, dbo.matricula.fechaMatricula, dbo.grado.numeroGrado, dbo.alumno.numAlumno, dbo.matricula.numeroAnno, dbo.seccion.nombreSeccion, dbo.matricula.nivelAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.numAlumno = dbo.matricula.numAlumno INNER JOIN
                  dbo.grado ON dbo.matricula.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                  dbo.seccion ON dbo.matricula.codigoSeccion = dbo.seccion.codigoSeccion AND dbo.grado.codigoGrado = dbo.seccion.codigoGrado where dbo.matricula.eliminacionLogica = 0
end
GO
--fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para verificar si alumno es de inicial o primaria 
Create procedure VerificarSiEsDeInicialoPrimaria(
@apPaternoAlumno varchar(20),
@apMaternoAlumno varchar(20),
@nivel varchar(10)
)
as begin
SELECT dbo.alumno.numAlumno, dbo.alumno.apPaternoAlumno, dbo.alumno.apMaternoAlumno , dbo.matricula.numeroAnno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.numAlumno = dbo.matricula.numAlumno	 
WHERE dbo.alumno.apPaternoAlumno  like '%'+@apPaternoAlumno+'%' and eliminacionLogica=0 and nivelAlumno=@nivel
end
GO
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para verificar si existe una matricula
Create procedure VerificarSiExisteMatricula(
@num varchar(10)
)
as begin
SELECT numAlumno, nivelAlumno
FROM     dbo.matricula 
WHERE eliminacionLogica =0 and numAlumno=@num
end
GO
--fin de la creacion del procedimiento almacenado 

------Procedimiento almacenado para buscar una matricula a traves del dni del alumno----
create procedure buscarMatricula(
@num int )
as
begin 
SELECT dbo.matricula.idMatricula, dbo.matricula.fechaMatricula, dbo.grado.numeroGrado, dbo.alumno.numAlumno, dbo.matricula.numeroAnno, dbo.seccion.nombreSeccion, dbo.matricula.nivelAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.numAlumno = dbo.matricula.numAlumno INNER JOIN
                  dbo.grado ON dbo.matricula.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                  dbo.seccion ON dbo.matricula.codigoSeccion = dbo.seccion.codigoSeccion AND dbo.grado.codigoGrado = dbo.seccion.codigoGrado  where dbo.matricula.numAlumno= @num and dbo.matricula.eliminacionLogica=0
end
GO
----fin de la creacion del procedimiento almacenado 


