create table Client (
Client_ID int not null primary key identity(1,1),
Client_Name varchar(64) not null,
Contact_Person varchar(40),
Agreement_Date date
)

 
create table Project(
Prj_ID int not null primary key identity(1,1),
Prj_Name varchar(64) not null,
Prj_Description varchar(1024),
Prj_Start_Date date,
Client int,
CONSTRAINT FK_Client FOREIGN KEY (Client) REFERENCES Client(Client_ID) ON DELETE CASCADE
)


CREATE TABLE Department(
ID int not null primary key identity(1,1) ,
DeptName varchar(32) not null
)
  

create table Employeess(
EmpID varchar(8) not null primary key,
EmpName varchar(64) not null,
Email varchar(64) null,
Phone varchar(815) not null,
Dept int not null constraint fkk  foreign key  references Department(ID) 
)

 

-- Adding new column
alter table Project 
ADD Prj_Cost decimal(12, 2) null

-- updating existing column   
alter table Project 
ALTER COLUMN Prj_Description varchar(512)

--adding constraint
alter table Project 
ADD CONSTRAINT FK_Client FOREIGN KEY (Client)
        REFERENCES Client (Client_ID)
        ON DELETE CASCADE

		-- Deleting existing table
-- Delete table Department
DROP TABLE Department;

