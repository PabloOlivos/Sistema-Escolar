-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA NOTA<<<<<<<-----------
-------------------------------------------------------------------------------------------
USE Colegio_DB
GO

--Creamos procedimiento almacenado para registrar notas----
create procedure agregarnota(
@calificacion tinyint,
@descripcion varchar(100) , 
@codigoCurso varchar(15), 
@numAlumno char(8), 
@codigoTrimestre varchar(10),
@numeroAnno int,
@numProfesor varchar(10),
@eliminacionLogica bit
)
as 
begin
insert into calificacion values ( @calificacion, @descripcion, @codigoCurso, @numAlumno, @codigoTrimestre, @numeroAnno,@numProfesor,@eliminacionLogica ) 
end 
GO
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para editar nota
create procedure editarnota(
@codigoCalificacion int,
@calificacion char(1),
@descripcion varchar(100) , 
@codigoCurso varchar(15), 
@numAlumno char(8), 
@codigoTrimestre varchar(10),
@numeroAnno int,
@numProfesor varchar(10),
@eliminacionLogica bit
)
as 
begin
UPDATE calificacion SET calificacion=@calificacion, descripcion=@descripcion, codigoCurso=@codigoCurso, numAlumno= @numAlumno,codigoTrimestre= @codigoTrimestre,numeroAnno= @numeroAnno,numProfesor=@numProfesor,eliminacionLogica=@eliminacionLogica 
where codigocalificacion=@codigoCalificacion
end 
GO
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento para listar nota de alumnos por curso y trimestre
create procedure listarNotaAlumnoPorCursoTrimestre(
@numAlumno char(8) ,
@codigoTrimestre varchar(10),
@codigoCurso varchar(15) 
)
as 
begin
SELECT dbo.calificacion.codigocalificacion, dbo.curso.nivel, dbo.alumno.numAlumno,dbo.alumno.apPaternoAlumno, dbo.alumno.apMaternoAlumno,dbo.alumno.nombreAlumno, dbo.trimestre.descripcionTrimestre, dbo.curso.nombreCurso, dbo.calificacion.descripcion, dbo.annoEscolar.numeroAnno, dbo.calificacion.calificacion
FROM     dbo.alumno INNER JOIN
                  dbo.calificacion ON dbo.alumno.numAlumno = dbo.calificacion.numAlumno INNER JOIN
                  dbo.annoEscolar ON dbo.calificacion.numeroAnno = dbo.annoEscolar.numeroAnno INNER JOIN
                  dbo.curso ON dbo.calificacion.codigoCurso = dbo.curso.codigoCurso INNER JOIN
                  dbo.trimestre ON dbo.calificacion.codigoTrimestre = dbo.trimestre.codigoTrimestre
				  where dbo.alumno.numAlumno = @numAlumno and dbo.trimestre.codigoTrimestre = @codigoTrimestre and dbo.curso.codigoCurso = @codigoCurso and dbo.calificacion.eliminacionLogica=0
end
GO
--fin de la creacion del procedimiento almacenado


--creamos procedimiento almacenado para verificar si una nota de un alumno ya existe
create  procedure validarSiExisteNota (
@descripcion varchar(100), 
@codigoCurso varchar(15),
@numAlumno char(8),
@codigoTrimestre varchar(10),
@numeroAnno	int
)
as 
begin 
select * from calificacion where  descripcion = @descripcion and codigoCurso = @codigoCurso and numAlumno = @numAlumno 
and codigoTrimestre = @codigoTrimestre and numeroAnno = @numeroAnno 
end 
GO
-----fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para listar notas de reporte
create procedure listarNotasReporte(
@num char(8),
@anno int, 
@nivel varchar(10),
@grado int, 
@seccion int, 
@curso varchar(15)
)
as
begin
SELECT        dbo.annoEscolar.numeroAnno, dbo.alumno.numAlumno, dbo.grado.nivelGrado, dbo.grado.numeroGrado, dbo.seccion.nombreSeccion, dbo.curso.nombreCurso, dbo.trimestre.descripcionTrimestre, dbo.calificacion.descripcion, 
                         dbo.calificacion.calificacion
FROM            dbo.alumno INNER JOIN
                         dbo.calificacion ON dbo.alumno.numAlumno = dbo.calificacion.numAlumno INNER JOIN
                         dbo.annoEscolar ON dbo.calificacion.numeroAnno = dbo.annoEscolar.numeroAnno INNER JOIN
                         dbo.curso ON dbo.calificacion.codigoCurso = dbo.curso.codigoCurso INNER JOIN
                         dbo.seccion ON dbo.annoEscolar.numeroAnno = dbo.seccion.numeroAnno INNER JOIN
                         dbo.grado ON dbo.seccion.codigoGrado = dbo.grado.codigoGrado INNER JOIN
                         dbo.trimestre ON dbo.calificacion.codigoTrimestre = dbo.trimestre.codigoTrimestre
						 where dbo.calificacion.numAlumno = @num and dbo.calificacion.numeroAnno = @anno
						 and dbo.grado.nivelGrado = @nivel and dbo.grado.codigoGrado = @grado
						 and dbo.seccion.codigoSeccion = @seccion and dbo.calificacion.codigoCurso = @curso	
end
GO
--fin del procedimiento almacenado 