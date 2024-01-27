Create database LavanderiaMC

use LavanderiaMC
go

Create table Usuarios_Sistema(
	key_usuario int identity (1,1),
	Nick varchar (20),
	Secreto varchar (20),
	Fecha_Registro datetime,
	Activo bit
)

Create Table Cat_Roles (
	Key_Rol int identity (1,1),
	Descripcion varchar(50),
	Fecha_Registro datetime,
	Activo bit
)

Create table Cat_Estatus (
	Key_rol int identity (1,1),
	Descripcion varchar(50),
	Fecha_Registro datetime,
	Activo bit
)

Create Table Equipos (
	key_Equipo int identity (1,1),
	Descripcion varchar(50),
	Fecha_Registro datetime,
	Activo bit,
)

Create table Personal(
	key_Persona int identity (1,1),
	Nombre varchar(50),
	A_Paterno varchar(50),
	A_Materno varchar(50),
	Edad int,
	Fecha_Registro datetime,
	activo bit
)

GRANT EXECUTE  TO LMCApiDbo;  
