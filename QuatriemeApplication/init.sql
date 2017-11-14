use GestContact;

create table Civilite(
	Id int identity,
	LibelleCourt nvarchar(3),
	LibelleLong nvarchar(30),
	primary key(Id)
);

create unique index uk_Civilite ON Civilite(LibelleCourt);

create table Personne(
	Id int identity,
	Nom nvarchar(50) not null,
	Prenom nvarchar(50),
	DateNaissance Datetime,
	Civilite_id int not null,
	primary key(Id),
	constraint fk_Personne_Civilite foreign key(Civilite_id) references Civilite(Id)
);

create index ix_Personne_Nom on Personne(Nom);

create table InformationContact(
	Id int identity, 
	TypeInfo int not null,
	Telephone nvarchar(15),
	Adresse1 nvarchar(100),
	Adresse2 nvarchar(100),
	CodePostal nvarchar(5),
	Ville nvarchar(50),
	Personne_id int not null,
	primary key(Id),
	constraint fk_InformationContact_Personne foreign key(Personne_id) references Personne(Id)
);

create unique index uk_InformationContact on InformationContact(TypeInfo, Personne_id);