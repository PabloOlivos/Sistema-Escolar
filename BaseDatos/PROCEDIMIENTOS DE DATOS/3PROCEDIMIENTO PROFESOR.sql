-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA PROFESOR<<<<<<<-----------
-------------------------------------------------------------------------------------------
USE Colegio_DB
GO

-------Creacion de procedimiento AgregarProfesor-----
create procedure agregarProfesor(
@numProfesor char(8) ,
@nombreProfesor varchar (40) ,
@apPaternoProfesor varchar (40) ,
@apMaternoProfesor varchar (40) ,
@edadProfesor int ,
@sexoProfesor char(1) ,
@direccionProfesor varchar (50) ,
@correoProfesor varchar (30) ,
@telefonoProfesor varchar (11) )
as
begin
 insert into Profesor values ( @numProfesor,@nombreProfesor, @apPaternoProfesor, @apMaternoProfesor,@edadProfesor, @sexoProfesor,@direccionProfesor, @correoProfesor, @telefonoProfesor)
end
GO
-------Finalizacion de procedimiento AgregarProfesor-----

-------Creacion de procedimiento EliminarProfesor-----
create procedure eliminarProfesor(@numProfesor char(8))
as 
begin 
delete from  Profesor where numProfesor=@numProfesor
end 
go
-------Finalizacion de procedimiento EliminarProfesor-----


-------Creacion de procedimiento ActualizarProfesor-----
create procedure actualizarProfesor(
@numProfesor char(8) ,
@nombreProfesor varchar (40) ,
@apPaternoProfesor varchar (40) ,
@apMaternoProfesor varchar (40) ,
@edadProfesor int ,
@sexoProfesor char(1) ,
@direccionProfesor varchar (50) ,
@correoProfesor varchar (30) ,
@telefonoProfesor varchar (11) )
as 
begin 
update  Profesor set NombreProfesor=@nombreProfesor, apPaternoProfesor=@apPaternoProfesor, @apMaternoProfesor=@apMaternoProfesor,edadProfesor=@edadProfesor, SexoProfesor=@sexoProfesor, DireccionProfesor=@direccionProfesor, CorreoProfesor=@correoProfesor, TelefonoProfesor=@telefonoProfesor  
where numProfesor = @numProfesor
end 
go
-------Finalizacion de procedimiento ActualizarProfesor-----



-------Creacion de procedimiento BuscarProfesor-----
create procedure buscarprofesor(
@numProfesor char(8)
)
as
begin
select * from Profesor where numProfesor = @numProfesor 
end 
go
-------Finalizacion de procedimiento BuscarProfesor-----




--creacion de procedimientos para listar los profesores libres 
create procedure listarprofesor
as
begin 
select numProfesor,nombreProfesor from profesor 
end
go
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para obtener datos de la tabla profesor
create procedure obtenerTablaProfesor
as 
begin
select 
numProfesor ,
nombreProfesor, 
apPaternoProfesor ,
apMaternoProfesor ,
edadProfesor ,
sexoProfesor ,
direccionProfesor, 
correoProfesor ,
telefonoProfesor  from profesor 
end
go
--fin de la creacion del procedimiento almacenado 

--creamos un procedimiento almacenado para listar profesores por grado y seccion 
create procedure listarProfesorPorGradoSeccion(
@anno int, 
@nivel varchar(10),
@grado int, 
@seccion int
)
as 
begin
SELECT dbo.profesor.numProfesor, dbo.profesor.nombreProfesor, dbo.profesor.apPaternoProfesor, dbo.profesor.apMaternoProfesor, dbo.seccion.nombreSeccion, dbo.grado.numeroGrado, dbo.seccion.nivel
FROM     dbo.grado INNER JOIN
                  dbo.seccion ON dbo.grado.codigoGrado = dbo.seccion.codigoGrado INNER JOIN
                  dbo.profesor ON dbo.seccion.numProfesor = dbo.profesor.numProfesor
				  where dbo.seccion.numeroAnno = @anno and dbo.seccion.nivel = @nivel and dbo.seccion.codigoGrado = @grado and dbo.seccion.codigoSeccion = @seccion
end 
go
----fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para editar los datos de un profesor desde el formulario usuario 
create procedure editarProfesor(
@num char(8),
@nombre varchar(40) ,
@apPaternoProfesor varchar(40) ,
@apMaternoProfesor varchar(40) ,
@correo varchar(40)
)
as 
begin 
update profesor set nombreProfesor = @nombre, apPaternoProfesor = @apPaternoProfesor,apMaternoProfesor = @apMaternoProfesor , correoProfesor =  @correo
where numProfesor = @num
end
go
--fin de la creacion del procedimiento almacenado 