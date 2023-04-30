create database Financial_condition;

use Financial_condition;
go

create table Roles 
(	
	Id int not null identity(1,1) primary key,
	Names nvarchar(50) check (Names <> '') not null
);
go

create table Users 
(	
	Id int not null identity(1,1) primary key,
	RolesId int not null,
	Login nvarchar(50) check (Login <> '') not null,
	Password nvarchar(10) check (Password <> '') not null,
	foreign key (RolesId) references Roles(Id)
);
go


create table Enterprise
(	
	Id int not null identity(1,1) primary key,
	Name nvarchar(50) check (Name <> '') not null,
	UserId int not null,
	foreign key (UserId) references Users(Id)
);
go

create table Financial_Indicators
(	
	EnterpriseId int not null,
	AnalisysDate date,
	PropertyStatus float,
	FinancialStability float,
	LiquidityAndSolvency float,
	BusinessActivity float,
	Profitability float,
	foreign key (EnterpriseId) references 