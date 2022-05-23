create database CARPINTERIA
use CARPINTERIA

create table EMPLEADO(
	IdEmpleado varchar (10) constraint IdEmpleado_PK PRIMARY KEY nonclustered(IdEmpleado) not null,
	NomEmpleado varchar(50) not null,
	ApellidoEmpleado varchar(50) not null,
	FuncionEmpleado varchar(50) not null,
	DirEmpleado varchar(50),
	DNIEmpleado int,
	EdadEmpleado int,
	FechaEmpleado date,
);

create table CLIENTE(
	IdCliente varchar(10),
	NomCliente varchar (50) not null,
	ApellidoCliente varchar(50) not null,
	dirCLiente varchar (60),
);

create table PROVEEDOR(
	CodProveedor VARCHAR(10) PRIMARY KEY NOT NULL,
	NomProveedor VARCHAR(50) NOT NULL,
	DirProveedor VARCHAR(100),
	TelfProveedor VARCHAR(9),
);

select * from PROVEEDOR

insert into EMPLEADO 
values('10410','Cristina','Perez','Administracion','C/ Portugal 24',77568211,25,'1997-03-10'),
	('10412','Francisco','Torres','Gerencia','Av. Vega 155',70886522,34,'1987-06-25'),
	('10414','Juan','Fernandez','Maquinista','C/ San Jorge 120',72648850,29,'1992-08-11'),
	('10416','Ana','Garcia','Secretaria','C/ Alemania 10',70856421,29,'1992-10-15'),
	('10418','Oscar','Cortes','Maquinista','C/ Unida 115',77560054,25,'1996-03-10')

insert into CLIENTE
values('11411','Nicolas','Otero','C/ Bolivar 147'),
	('11413','Nuria','Martinez','C/ Grau 155'),
	('11415','Ricardo','Torres','C/ San Martin 180'),
	('11417','Alberto','Espinosa','C/ Jorge Chavez 1005')

insert into PROVEEDOR 
values('11510','Maderera Castillo','Av Feliz 154','914857456'),
	('11511','Emp Felices','Av Esmeralda 1004','910856331'),
	('11512','Maderera Esperanza','C/ Esseba 152','955120021'),
	('11513','Emp Oceano','Av Feliz 150','900456221')

--elimina los registros de una tabla
truncate table PROVEEDOR