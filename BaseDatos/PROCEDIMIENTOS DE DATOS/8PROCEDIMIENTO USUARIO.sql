-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA USUARIO<<<<<<<-----------
-------------------------------------------------------------------------------------------
USE Colegio_DB
GO

--creamos procedimiento almacenado para mostrar un usuario buscado
create procedure loginUser(@nombreUsuario varchar(10),@contraseUsuario varchar(20))
as
begin 
select * from usuario where username=@nombreUsuario and contrasenna = @contraseUsuario
end
GO
--fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para verificar si existe un usuario
create procedure VerificarSiExisteUsuario(@nombreUsuario varchar(10))
as begin
select * from usuario where username = @nombreUsuario
end 
GO
--fin de la creacion del procedimiento almacenado 

--creamos procedimiento almacenado para listar los profesores
create procedure listarProfesores(@num varchar(10))
as begin 
select * from usuario where cargoUsuario='Profesor' and numUsuario= @num
end
GO
--fin de la creacion del procedimiento almacenado

--creamos procedimiento almacenado para listar directores
create procedure listarDirector(@num varchar(10))
as begin 
select * from usuario where cargoUsuario='Director' and numUsuario= @num
end
GO
--fin de la creacion del procedimietno almacenado 


--creamos un procedimiento almacenado para crear usuario
create procedure registrarUsuario (
@usuario varchar (11) ,
@contrasenna varchar (12) ,
@numUsuario char(8) ,
@nombreUsuario varchar(40) , 
@apPaternoUsuario varchar (40) ,
@apMaternoUsuario varchar (40) ,
@correoUsuario varchar (40) ,
@cargoUsuario varchar (11) 
)
as 
begin 
insert into usuario values ( @usuario, @contrasenna, @numUsuario, @nombreUsuario, @apPaternoUsuario,  @apMaternoUsuario,@correoUsuario, @cargoUsuario) 
end
GO
---fin de la creacion del procedimiento registrarUsuario

--Creamos un procedimiento almacenado para eliminar un usuario 
create procedure eliminarUsuario (
@num char(8)
)
as 
begin
delete usuario where numUsuario = @num
end 
GO
--fin de la de creacion del procedimiento eliminarUsuario 

--creamos un procedimiento para buscar un usuario 
create procedure buscarUsuario (
@num char(8)
)
as 
begin
select * from usuario where numUsuario = @num
end 
GO

--fin de la creacion del procedimiento buscarUsuario

--creamos un procedimiento para actualizar los datos de un profesor desde el formulario usuario 
create procedure actualizarUsuario (
@num char(8) ,
@contrasenna varchar(12),
@nombreUsuario varchar(40),
@apPaternoUsuario varchar (40) ,
@apMaternoUsuario varchar (40) ,
@correoUsuario varchar (40)
)
as
begin 
update usuario set contrasenna = @contrasenna, nombreUsuario = @nombreUsuario, apPaternoUsuario = @apPaternoUsuario, apMaternoUsuario = @apMaternoUsuario,correoUsuario = @correoUsuario
where numUsuario = @num
end
GO

--fin de la creacion del procedimiento almacenado 

