-------------------------------------------------------------------------------------------
---->>>>>>>>>PROCEDIMIENTOS ALMACENADOS TABLA GRADO<<<<<<<-----------
-------------------------------------------------------------------------------------------

USE Colegio_DB
GO

--creamos procedimiento para listar los grados de inicial 
create procedure listarGradoI
as 
begin
SELECT codigoGrado,numeroGrado
FROM     dbo.grado 
			where nivelGrado = 'Preescolar'
end
GO
--fin de la creacion del procedimiento almacenado 


--creamos procedimiento para listar los grados de primaria 
create procedure listarGradoP
as 
begin
SELECT codigoGrado,numeroGrado
FROM     dbo.grado
		 where nivelGrado = 'Primaria' 
end
GO
--fin de la creacion del procedimiento almacenado 