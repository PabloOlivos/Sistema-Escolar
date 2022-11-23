-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA ALUMNO<<<<<<<-----------
-------------------------------------------------------------------------------------------

USE Colegio_DB
GO

----Creacion de procedimiento de AgregarAlumno----
CREATE PROCEDURE agregaralumno(
@numAlumno char(8),
@nombreAlumno varchar (50), 
@apPaternoAlumno varchar (50),
@apMaternoAlumno varchar (50),
@edadAlumno int,
@sexoAlumno char (1),
@direccionAlumno varchar(100),
@tutorAlumno varchar (100),
@numeroTelefonoTutor varchar(11)
)
as
begin
insert into alumno values (@numAlumno,@nombreAlumno,@apPaternoAlumno,@apMaternoAlumno,@edadAlumno, @sexoAlumno,@direccionAlumno, @tutorAlumno,@numeroTelefonoTutor)
end
GO
----Finalizacion del procedimiento de AgregarAlumno----



----Creacion de procedimiento de EliminarAlumno----
CREATE PROCEDURE eliminaralumno(
@num char(8)
)
as 
begin 
delete from  Alumno where numAlumno = @num
end 
go
----Finalizacion del procedimiento de EliminarAlumno----



----Creacion de procedimiento de ActualizarAlumno----
CREATE PROCEDURE actualizaralumno(
@numAlumno char(8),
@nombreAlumno varchar (50), 
@apPaternoAlumno varchar (50),
@apMaternoAlumno varchar (50),
@edadAlumno int,
@sexoAlumno char (1),
@direccionAlumno varchar(100),
@tutorAlumno varchar (100),
@numeroTelefonoTutor varchar(11)
)
as 
begin 
update  Alumno set NombreAlumno=@nombreAlumno, ApPaternoAlumno=@apPaternoAlumno, ApMaternoAlumno=@apMaternoAlumno,edadAlumno=@edadAlumno ,SexoAlumno=@sexoAlumno, DireccionAlumno=@direccionAlumno, tutorAlumno=@tutorAlumno,numeroTelefonoTutor=@numeroTelefonoTutor
where numAlumno = @numAlumno
end 
go
----Finalizacion del procedimiento de ActualizarAlumno----

----Creacion de procedimiento de BuscarAlumno----
CREATE PROCEDURE buscaralumno(
@num varchar(30)
)
as
begin
select * from Alumno where numAlumno = @num
end 
go
----Finalizacion del procedimiento de BuscarAlumno----

--creamos procedimiento almacenado para obtener la tabla alumno
create procedure obtenerTablaAlumno
as
begin
SELECT 
numAlumno ,
nombreAlumno ,
apPaternoAlumno ,
apMaternoAlumno ,
edadAlumno ,
sexoAlumno ,
direccionAlumno ,
tutorAlumno ,
numeroTelefonoTutor
FROM alumno 
end
GO
--fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para verificar si ya existe un alumno
create procedure VerificarSiExisteAlumno(
@num char(8))
as begin 
SELECT numAlumno FROM alumno 
          WHERE  numAlumno=@num

END  
GO
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para buscar alumno con la funcion LIKE 
create procedure buscarAlumnoLike(
@num char(8))
as begin 
SELECT numAlumno,nombreAlumno,apPaternoAlumno,apMaternoAlumno FROM alumno 
          WHERE  numAlumno like '%'+@num+'%'
END  
GO
--fin de la creacion del procedimiento almacenado

--creamos un procedimiento almacenado para listar alumnos por grado y seccion 
create procedure listarAlumnosPorGradoSeccion(
@anno int,
@nivel varchar(10) ,
@grado int ,
@seccion int
)
as
begin
SELECT dbo.matricula.fechaMatricula, dbo.alumno.numAlumno, dbo.alumno.nombreAlumno, dbo.alumno.apPaternoAlumno, dbo.alumno.apMaternoAlumno, dbo.grado.numeroGrado, dbo.seccion.nombreSeccion, dbo.matricula.nivelAlumno
FROM     dbo.alumno INNER JOIN
                  dbo.matricula ON dbo.alumno.numAlumno = dbo.matricula.numAlumno INNER JOIN
                  dbo.grado ON dbo.matricula.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                  dbo.seccion ON dbo.matricula.codigoSeccion = dbo.seccion.codigoSeccion AND dbo.grado.codigoGrado = dbo.seccion.codigoGrado
				  where dbo.matricula.codigoGrado = @grado and dbo.matricula.codigoSeccion = @seccion and dbo.matricula.eliminacionLogica = 0 and dbo.matricula.nivelAlumno = @nivel and dbo.matricula.numeroAnno = @anno
end 
GO
--fin de la creacion del procedimiento almacenado 






