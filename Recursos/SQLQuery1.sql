-- Si hace falta eliminar alguna tabla, mejor hacerlo a mano y a lo bruto
-- Hace falta crear una BBDD llamada ProyectoRogelike

use ProyectoRogelike;

--Tablas

CREATE TABLE Piso(
	IdPiso int identity (1,1) NOT NULL,
	Nombre nvarchar (50) not null,
	NumEstancias int not null,
	Texto nvarchar (255) not null,
	primary key clustered (IdPiso asc)
);

create table Personaje(
	IdPersonaje int identity (1,1) not null,
	Danio int not null,
	Turno bit not null,
	Vida int not null,
	Hambre int null,
	Nombre nvarchar(40) null,
	Debilidad nvarchar(30) null,
	Decripcion nvarchar(255) null,
	primary key clustered (IdPersonaje asc)
);

create table Estancia(
	IdEstancia int identity (1,1) not null,
	Tipo nvarchar(20) not null,
	Texto nvarchar (255) not null,
	IdPersonaje int null,
	IdPiso int null,
	primary key clustered (IdEstancia asc),
	foreign key (IdPersonaje) references Personaje(IdPersonaje) on delete cascade on update cascade,
	foreign key (IdPiso) references Piso(IdPiso) on delete cascade on update cascade
);

create table Narracion(
	IdNarracion int identity (1,1) not null,
	Texto nvarchar (255) not null,
	primary key clustered (IdNarracion asc)
);

create table Objeto(
	IdObjeto int identity (1,1) not null,
	Tipo nvarchar(20) not null,
	Nombre nvarchar(30) not null,
	Danio int null,
	Efecto nvarchar(20) null,
	Equipable bit null,
	primary key clustered(IdObjeto asc)
);

create table Cofre(
	IdCofre int identity (1,1) not null,
	Tipo nvarchar(20) not null,
	Texto nvarchar(255) not null,
	IdObjeto int null,
	primary key clustered(IdCofre asc),
	foreign key (IdObjeto) references Objeto(IdObjeto) on delete cascade on update cascade
);

create table Inventartio(
	IdInventario int identity(1,1) not null,
	CapacidadMax int not null,
	IdObjeto int null,
	primary key clustered(IdInventario asc),
	foreign key (IdObjeto) references Objeto(IdObjeto) on delete cascade on update cascade
);

create table Tiene(
	IdEstancia int,
	IdNarracion int,
	foreign key (IdNarracion) references Narracion(IdNarracion),
	foreign key (IdEstancia) references Estancia(IdEstancia)
);

create table compone(
	IdPiso int,
	IdEstancia int,
	foreign key (IdPiso) references Piso(IdPiso),
	foreign key (IdEstancia) references Estancia(IdEstancia)
);

--Inserts

set identity_insert Piso on
insert into Piso (IdPiso, Nombre, NumEstancias, Texto) values 
(1, 'alcantarillado', 3, 'El viejo sistema de alcantarillado de la ciudad')
set identity_insert Piso off

set identity_insert Personaje on
insert into Personaje (IdPersonaje, Danio, Turno, Vida, Hambre) values 
(1, 2, 1, 20, 100)
insert into Personaje (IdPersonaje, Danio, Turno, Vida, Nombre, Debilidad, Decripcion) values 
(2, 10, 0, 30, 'Boblin, El Goblin', 'Bonk', 'Pequeño y verde, no parece una amenaza, pero mejor no te confies')
set identity_insert Personaje off

set identity_insert Estancia on
insert into Estancia (IdEstancia, Tipo, Texto, IdPiso) values 
(1, 'Narracion', 'te encuentras en un camino estrecho del sistema de alcantarillas, a la izquierda ves el canal por el que luye el agua. No parece que cubra mucho', 1)
insert into Estancia (IdEstancia, Tipo, Texto, IdPiso) values 
(2, 'Combate', 'Parece que vas a tener problemas. Preparate', 1)
insert into Estancia (IdEstancia, Tipo, Texto, IdPiso) values 
(3, 'Botin', 'eso que se ve es un cofre??', 1)
set identity_insert Estancia off

