


--Llenado de dato para la tabla alumno utilizando el PA agregarAlumno 

exec agregaralumno '72589658', 'JUAN' , 'PEREZ', 13,'M','Av Junin', 'MARIA ROSA','975865258'
exec agregaralumno '76515551', 'JOSE LUIS' , 'GONZALES', 8,'M','Av Cuzco', 'JUANA','979845216'
exec agregaralumno '79160217', 'JOSÉ' , 'GOMEZ', 5,'M','Av Sullana', 'FERNANDO','954465336'
exec agregaralumno '63247185', 'MARÍA GUADALUPE' , 'FERNANDEZ', 10,'F','Av Piura', 'DANIEL','977727035'
exec agregaralumno '25696971', 'FRANCISCO' , 'LOPEZ', 15,'M','Av Arequipa', 'CARLOS','907139082'
exec agregaralumno '30787615', 'GUADALUPE' , 'DIAZ', 14,'F','Av Loreto', 'JORGE','906244998'
exec agregaralumno '33299098', 'MARÍA' , 'MARTINEZ', 10,'F','Av Lima', 'RICARDO','923411156'
exec agregaralumno '31726545', 'JUANA' , 'GARCIA', 14,'F','Av Tarapaca', 'MIGUEL','999309686'
exec agregaralumno '47431609', 'ANTONIO' , 'SANCHEZ', 8,'M','Av Grau', 'EDUARDO','957875865'
exec agregaralumno '49847991', 'ROBERTO' , 'ROMERO', 6,'M','Av Bilbao', 'JAVIER','969803593'
exec agregaralumno '35631132', 'MIGUEL ÁNGEL' , 'SOSA', 9,'M','Av San Martin', 'RAFAEL','996954058'
exec agregaralumno '46214567', 'PEDRO' , 'TORRES', 9,'M','Av Arenales', 'MARTIN','989492893'
exec agregaralumno '22059147', 'ALEJANDRO' , 'ALVAREZ', 4,'M','Av 2 de Abril', 'RAUL','972064474'
exec agregaralumno '59362163', 'MANUEL' , 'RUIZ', 11,'M','Av 3 de marzo', 'JOSEFINA','999789702'
exec agregaralumno '27507214', 'MARGARITA' , 'RAMIREZ', 12,'F','Av Chancay', 'JOSE ANTONIO','958018780'
exec agregaralumno '12658685', 'MARÍA DEL CARMEN' , 'FLORES',16,'F','Av Callao', 'ARTURO','994984587'
GO

SELECT * FROM alumno
GO

--LLENADO DE DATOS PARA LA TABLA ANNO ESCOLAR
exec registrarAnnoEscolar 2019,'2019/03/2','2019/12/20'
GO

--Insertamos los cursos de primaria e inicial a la tabla curso
insert into curso values ( 'COM01', 'Comunicacion','Primaria', 'Exposicion' , 'Trabajo', 'Examen')
insert into curso values ('PSC01'	, 'Personal Social','Primaria' ,'Exposicion'	,'Trabajo' ,	'Examen')
insert into curso values ('EFS01'	,'Educacion Fisica','Primaria'	,'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('ACL01'	,'Arte y Cultura','Primaria'	,'Exposicion',	'Trabajo',	'Examen')
insert into curso values ('MAT01'	,'Matematica','Primaria',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('CTA01',	'Ciencia Tecnologia y Ambiente','Primaria',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('REL01', 'Religion','Primaria', 'Exposicion', 'Trabajo' , 'Examen')
insert into curso values ( 'ICOM01', 'Comunicacion','Inicial', 'Exposicion' , 'Trabajo', 'Examen')
insert into curso values ('IMAT01'	,'Matematica','Inicial',	'Exposicion' ,	'Trabajo',	'Examen')
insert into curso values ('IPSC01'	, 'Personal Social','Inicial' ,'Exposicion'	,'Trabajo' ,	'Examen')
insert into curso values ('ICTA01',	'Ciencia Tecnologia y Ambiente','Inicial',	'Exposicion' ,	'Trabajo',	'Examen')
GO

SELECT * FROM curso
GO

--insertamos los grados a la tabla correspondiente
insert into grado values ( 3, 'Inicial') 
insert into grado values ( 4, 'Inicial') 
insert into grado values ( 5, 'Inicial') 
insert into grado values  ( 1, 'Primaria') 
insert into grado values  ( 2, 'Primaria') 
insert into grado values  ( 3, 'Primaria') 
insert into grado values  ( 4, 'Primaria') 
insert into grado values  (5, 'Primaria') 
insert into grado values  ( 6, 'Primaria') 
GO

SELECT * FROM grado
GO

--insertamos los datos a la tabla trimestre
insert into trimestre values ('1Tri', 'Primer Trimestre') 
insert into trimestre values ('2Tri', 'Segundo Trimestre') 
insert into trimestre values ('3Tri', 'Tercer Trimestre') 
GO

SELECT * FROM trimestre
GO

----Llenado de dato para la tabla PROFESOR utilizando el PA agregarAlumno 
exec agregarProfesor '72457239', 'BRAYAN','MARTINEZ' , 25, 'M', 'Av Sullana', 'Brayan@gmail.com' , '988182681'
exec agregarProfesor '64582356', 'JOSE','RAMIREZ' , 28, 'M', 'Av Piura', 'Jose@gmail.com' , '955865235'
exec agregarProfesor '45678958', 'FRANCISCO','FLORES' , 30, 'M', 'Av Cuzco', 'Francisco@gmail.com' , '975864523'
exec agregarProfesor '02568954', 'ENRIQUE','BENITES' , 22, 'M', 'Av 24 de abril', 'Enrique@gmail.com' , '975864256'
exec agregarProfesor '01589523', 'VERONICA','ACOSTA' , 40, 'F', 'Av Huanuco', 'Veronica@gmail.com' , '975425421'
exec agregarProfesor '02587458', 'MARIA','MEDINA' , 35, 'F', 'Av Junin', 'Maria@gmail.com' , '978546231'
exec agregarProfesor '03698521', 'ROSA','HERRERA' , 27, 'F', 'Av Cajamarca', 'Rosa@gmail.com' , '998562562'
exec agregarProfesor '01258974', 'LETICIA','SUAREZ' , 25, 'F', 'Av Balta', 'Leticia@gmail.com' , '985456215'
exec agregarProfesor '01256983', 'ROCIO','AGUIRRE' , 30, 'F', 'Av Bolivar', 'Rocio@gmail.com' , '978546123'
GO

SELECT * FROM agregarProfesor
GO

--llenado a la base de datos seccion 
exec registrarSeccion 'A', 1, '72457239', 2019, 25, 'Inicial' 
exec registrarSeccion 'A', 2, '64582356', 2019, 25, 'Inicial' 
exec registrarSeccion 'A', 3, '45678958', 2019, 25, 'Inicial' 
exec registrarSeccion 'A', 4, '02568954', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 5, '01589523', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 6, '02587458', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 7, '03698521', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 8, '01258974', 2019, 25, 'Primaria' 
exec registrarSeccion 'A', 9, '01256983', 2019, 25, 'Primaria' 
GO
--reinicia el contador a cero 
--DBCC CHECKIDENT (seccion, RESEED, 0)

Select * from seccion
GO

--llenamos datos a la tabla matricula a traves del procedimiento almacenado 
exec registrarMatricula '2019-03-05' , 2, '22059147', 2019, 1, 'Inicial' , 'false'
exec registrarMatricula '2019-03-06' , 5, '25696971', 2019, 5, 'Primaria' , 'false'
exec registrarMatricula '2019-03-08' , 4, '72589658', 2019, 7, 'Primaria' , 'false'
exec registrarMatricula '2019-03-15' , 8, '47431609', 2019, 4, 'Primaria' , 'false'
exec registrarMatricula '2019-03-13' , 9, '12658685', 2019, 9, 'Primaria' , 'false'
GO


--llenado de datos de la tabla nota
exec agregarnota 'A', 'Exposicion', 'COM01' , '25696971', '1Tri', 2019,'01589523', 'false'
exec agregarnota 'A', 'Trabajos', 'COM01' , '25696971', '1Tri', 2019, '01589523','false'
exec agregarnota 'A', 'Examen', 'COM01' , '25696971', '1Tri', 2019, '01589523','false'
exec agregarnota 'A', 'Exposicion', 'COM01' , '72589658', '1Tri', 2019,'02568954', 'false'
exec agregarnota 'A', 'Trabajos', 'COM01' , '72589658', '1Tri', 2019,'02568954', 'false'
exec agregarnota 'A', 'Examen', 'COM01' , '72589658', '1Tri', 2019, '02568954','false'
GO



--llenado del registro de usuario

exec registrarUsuario '70885752', '70885752', '70885752', 'Frank Antonio', 'Pinin Ato', 'ejemplo.com', 'Director'
GO

