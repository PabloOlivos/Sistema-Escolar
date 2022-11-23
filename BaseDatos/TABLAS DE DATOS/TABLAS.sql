
create database Colegio_DB -- creamos la base de datos
GO

use Colegio_DB -- Usamos la database creada
GO
------Creacion de la tabla alumno-----------------
create table alumno(
numAlumno char (8) Primary Key not null,
nombreAlumno varchar (40) not null,
apPaternoAlumno varchar (40) not null,
apMaternoAlumno varchar (40) not null,
edadAlumno tinyint not null,
sexoAlumno char(1) not null,
direccionAlumno varchar (100) not null,
tutorAlumno varchar(50) not null, 
numeroTelefonoTutor varchar(11) null,
CONSTRAINT ch_sexo CHECK(sexoAlumno in ('F','M'))
)
GO
------Fin de la creacion  de la tabla alumno-------

------Creacion de la tabla Año Escolar-----------------
create table annoEscolar(
numeroAnno int primary key not null, 
fechaInicio date not null, 
fechaTermino date not null
)
GO
------Fin de la creacion  de la tabla Año Escolar-------

-----Creacion de la Tabla Profesor-------------------
create table  profesor(
numProfesor char(8) Primary Key not null,
nombreProfesor varchar (40) not null,
apPaternoProfesor varchar (40) not null,
apMaternoProfesor varchar (40) not null,
edadProfesor int not null,
sexoProfesor char(1) not null,
direccionProfesor varchar (50) not null,
correoProfesor varchar (30) not null,
telefonoProfesor varchar (11) null,
CONSTRAINT chsexo CHECK(sexoProfesor in ('F','M'))

)
GO
-----Fin de la creacion de la tabla Profesor----------

------Creacion de la tabla Trimestre-----------------
create table trimestre(
codigoTrimestre varchar(10) primary key not null,
descripcionTrimestre varchar (25) not null
)
GO
------Fin de la creacion  de la tabla Trimestre-------
------Creacion de la tabla Usuario-----------------

create table usuario(
username varchar (11) Primary key not null,
contrasenna varchar (12) unique not null,
numUsuario char(8) unique not null,
nombreUsuario varchar(40) not null, 
apePaternoUsuario varchar (40) not null,
apeMaternoUsuario varchar (40) not null,
correoUsuario varchar (40) not null,
cargoUsuario varchar (11) not null,
)
GO
------Fin de la creacion  de la tabla Usuario-------
------Creacion de la tabla Curso-----------------
create table curso(
codigoCurso varchar(15) Primary Key not null,
nombreCurso varchar (50)not null,
nivel varchar(20),
competencia1 varchar (80) not null,
competencia2 varchar (80) not null,
competencia3 varchar (80) not null,
)
GO

------Fin de la creacion  de la tabla Curso------
--creamos la tabla grado
create table grado(
codigoGrado int identity(1,1) Primary key not null,
numeroGrado int,
nivelGrado char(9)
)
GO

-- fin de la tabla grado
--Creamos la tabla seccion
create table seccion(
codigoSeccion int IDENTITY(1,1) primary key not null,
nombreSeccion varchar(30)  not null,
codigoGrado int, --fk
numProfesor char(8), --fk 
numeroAnno int, --fk
numeroVacantes int,
nivel varchar(20),
CONSTRAINT fk_gradoo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_annoEscolar FOREIGN KEY (numeroanno) REFERENCES annoEscolar (numeroanno),
CONSTRAINT fk_profesoor FOREIGN KEY (numProfesor) REFERENCES Profesor (numProfesor)
)
GO
--fin de la creacion de la tabla seccion
------Creacion de la tabla Matricula-----------------
create table matricula(
idMatricula int Identity(1,1) primary key not null, 
fechaMatricula date not null,
codigoGrado int, --fk
numAlumno char(8), --fk 
numeroAnno int,  --fk
codigoSeccion int, --fk
nivelAlumno  varchar(20),
eliminacionLogica bit ,
CONSTRAINT fk_graddo FOREIGN KEY (codigoGrado) REFERENCES grado (codigoGrado),
CONSTRAINT fk_alumno FOREIGN KEY (numAlumno) REFERENCES alumno (numAlumno),
CONSTRAINT fk_annoEscolaar FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno),
CONSTRAINT fk_seccionn FOREIGN KEY (codigoSeccion) REFERENCES seccion (codigoSeccion)
)
GO
------Fin de la creacion  de la tabla Matricula------
------Creacion de la tabla Nota----------------
create table calificacion(
codigocalificacion int Identity(1,1) primary key not null, 
calificacion char(1) not null, 
descripcion varchar(100) not null, 
codigoCurso varchar(15), --fk
numAlumno char(8), --fk 
codigoTrimestre varchar(10), --fk
numeroAnno int, --fk
dniProfesor varchar(10),
eliminacionLogica bit
CONSTRAINT fk_curso FOREIGN KEY (codigoCurso) REFERENCES Curso (codigoCurso),
CONSTRAINT fk_Trimestre FOREIGN KEY (codigoTrimestre) REFERENCES Trimestre (codigoTrimestre),
CONSTRAINT fk_anoEscolar  FOREIGN KEY (numeroAnno) REFERENCES annoEscolar (numeroAnno),
CONSTRAINT fk_alumnno  FOREIGN KEY (numAlumno) REFERENCES alumno (numAlumno)
)
GO
------Fin de la tabla Nota---------------


