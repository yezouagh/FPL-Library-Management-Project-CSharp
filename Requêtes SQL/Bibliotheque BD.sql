------------------------------------------------------------------Création de la base de donnees-----------------------------------------------------------------
create database  Bibliothèque
Go
--------------------------------------------------------//--Création des tables de la base de donnees--//-------------------------------------------------------

-------------------------------------------------------------------Table d'Ouvrage------------------------------------------------------
create table Ouvrage(
Cote nvarchar(30) primary key,
Titre nvarchar(200),
PremierInventair nvarchar(20),
DernierInventair nvarchar(20),
Auteur nvarchar(150),
Domaine nvarchar(80),
SousDomaine nvarchar(80),
Nversement nvarchar(10),
Date_Entre date,
Qte int,
TypeOuvrage nvarchar(80),
Observation nvarchar(255)
)
Go

-------------------------------------------------------------------Table Quantite disponible d'Ouvrage------------------------------------------------------
create table Quantite_Ouvrage_Disponible(
Cote nvarchar(30) foreign key references Ouvrage(Cote) 
ON UPDATE CASCADE
ON DELETE CASCADE,
Quantite int,
primary key (Cote)
)
Go
-------------------------------------------------------------------Table Type d'emprunteur------------------------------------------------------
create table TypeEmprunteur(
IdTypeEmp int primary key,
Dèsignation nvarchar(60)
)
Go
-------------------------------------------------------------------Table Filier------------------------------------------------------
create table Filier(
CodeFilier nvarchar(10) primary key,
Dèsignation nvarchar(80)
)
Go
-------------------------------------------------------------------Table d'emprunteur------------------------------------------------------
create table Emprunteur(
ID_Emprunteur nvarchar(50) primary key,
CIN nvarchar(60),
Nom nvarchar(30),
Prenom nvarchar(30),
CodeFilier nvarchar(10) foreign key references Filier(CodeFilier)
ON UPDATE CASCADE
ON DELETE CASCADE,
DateNaissance date,
LieuNaissance nvarchar(50),
Sexe varchar(1),
Email nvarchar(60),
Tele nvarchar(20),
IdTypeEmp int foreign key references TypeEmprunteur(IdTypeEmp)
ON UPDATE CASCADE
ON DELETE CASCADE
)
Go
-------------------------------------------------------------------Table Emprunter------------------------------------------------------
create table Emprunter(
CodePret int primary key identity(1,1),
ID_Emprunteur nvarchar(50) foreign key references Emprunteur(ID_Emprunteur)
ON UPDATE CASCADE
ON DELETE CASCADE,
Cote nvarchar(30) foreign key references Ouvrage(Cote)
ON UPDATE CASCADE
ON DELETE CASCADE,
Semetre nvarchar(4),
DateEmprunt date default getdate(),
Date_Retour_prevoyer date,
Date_Reteur_Reel date,
retourne bit default 0
)
Go
-------------------------------------------------------------------Table d'emprunteur Sanctionne------------------------------------------------------
create table Emprunteur_Sanctionne(
Code_Sanction int primary key identity(1,1),
CodePret int foreign key references Emprunter(CodePret)
ON UPDATE CASCADE
ON DELETE CASCADE,
Date_Debut_Sanction date default getdate(),
Date_Fin_Sanction date,
Observation nvarchar(255)
)
Go
-------------------------------------------------------------------Insert into les tables des types est autre------------------------------------------------------
insert into TypeEmprunteur values(1,'Etudiant'),(2,'Extern'),(3,'Prof')
insert into Filier values('NAN','Indéfini')

insert into Filier values('SMP','Sciences de la matiere physique'),('SEG','Sciences economiques et gestion'),
('SMA','Sciences mathematiques et applications'),('SMIA','Sciences mathematiques et informatique'),
('SVI','Sciences de la vie'),('AGRO','Agroalimentaire')
,('PA','Peche et aquaculture'),('IG','Informatique de gestion'),('MHT','Marketing hotelier et touristique'),('MMA','Master : mathematiques et appliquees')
select * from TypeEmprunteur
select * from Filier
Go 
-----------------------------------------------------------------//--Triggers---//---------------------------------------------------

-------------------------------------------------------------------Quantite d'ouvrage------------------------------------------------------

create trigger quantitecontrole1 on Ouvrage
after insert
as 
begin
insert into Quantite_Ouvrage_Disponible select Cote,Qte from inserted
end
Go
create trigger quantitecontrole2 on Ouvrage
after update
as 
begin
update Quantite_Ouvrage_Disponible set  Quantite=(select Qte from  inserted) where Cote in (select Cote from  inserted)
end
Go
create trigger quantitecontrole4 on Emprunter
after update
as 
begin 
update Quantite_Ouvrage_Disponible set  Quantite=Quantite+1 where Cote in (select Cote from  inserted)
end
Go
create trigger quantitecontrole3 on Emprunter
after insert
as
begin
update Quantite_Ouvrage_Disponible set  Quantite=Quantite-1 where Cote in (select Cote from  inserted)
end
Go
-------------------------------------------------------------------Augmenter la quantite apres l'isertion d'une nouvelle ouvrage ayant le meme cote------------------------------------------------------

create trigger Augmenterquantite on Ouvrage
instead of insert
as 
begin
declare @cote nvarchar(30) 
select @cote=Cote from inserted
if(@cote  in (select Cote from Ouvrage))
begin
update Ouvrage set  Qte=Qte+(select Qte from  inserted) where Cote=@cote
end
else
begin
insert into Ouvrage select * from inserted
end
end
Go

----------------------------------------------------------------//---Function & Procedures & vues---//---------------------------------------------------

create function NbrSanction(@ID nvarchar(50))
returns int
as
begin
declare @count int
select @count=count(Emprunteur_Sanctionne.CodePret) from Emprunteur_Sanctionne inner join Emprunter on Emprunteur_Sanctionne.CodePret=
Emprunter.CodePret where ID_Emprunteur=@ID
return @count
end
Go
---------------------------------------------------------------- Les emprunteurs qui seront sanctionnee------------------------------------------------------
Go
create function Sanctionne()
returns @Asanctionne table (
CodePret int,
Cote nvarchar(30),
ID_Emprunteur nvarchar(50),
Nom nvarchar(30),
Prenom nvarchar(30),
DateEmprunt date,
Date_Retour_prevoyer date,
[Nombre de sanctions] int
)
as
begin
declare @CodePret int
DECLARE cur CURSOR FOR
SELECT CodePret
FROM Emprunter where retourne=0 and CodePret  not in (select  CodePret from Emprunteur_Sanctionne) and Date_Retour_prevoyer<getdate();
OPEN cur;
FETCH NEXT FROM cur into @CodePret;
WHILE @@FETCH_STATUS = 0
   BEGIN
declare @count int
declare @id nvarchar(50)
select @id=ID_Emprunteur from Emprunter where CodePret=@codePret
select @count=dbo.NbrSanction(@id)
insert into @Asanctionne select Emprunter.CodePret,Emprunter.Cote,Emprunter.ID_Emprunteur,
Emprunteur.Nom,Emprunteur.Prenom,DateEmprunt,Date_Retour_prevoyer,@count from Emprunter inner join Emprunteur on
 Emprunter.ID_Emprunteur=Emprunteur.ID_Emprunteur where Emprunter.CodePret=@CodePret
   FETCH NEXT FROM cur into @CodePret;
   END;
CLOSE cur;
DEALLOCATE cur;
return 
end

Go
-------------------------------------------------------------------Les sanctionnes------------------------------------------------------
create view LesSanctionnes
as
select Code_Sanction,Emprunter.Cote,Emprunteur.ID_Emprunteur,Emprunteur.Nom,Emprunteur.Prenom,Date_Debut_Sanction,Date_Fin_Sanction,
Observation from Emprunteur_Sanctionne inner join Emprunter on Emprunteur_Sanctionne.CodePret= Emprunter.CodePret inner join Emprunteur on Emprunter.ID_Emprunteur=Emprunteur.ID_Emprunteur
where Date_Fin_Sanction>=getdate()
Go
-------------------------------------------------------------------Les auteurs ------------------------------------------------------
create view Auteur
as
select distinct Auteur from Ouvrage
Go
-------------------------------------------------------------------Les Domaines ------------------------------------------------------
create view Domaine
as
select distinct Domaine from Ouvrage
Go
-------------------------------------------------------------------Les Sous Domaines ------------------------------------------------------
create view SousDomaine
as
select distinct SousDomaine from Ouvrage
Go
-------------------------------------------------------------------Les Types d'Ouvrage ------------------------------------------------------
create view TypesOuvrage
as
select distinct TypeOuvrage from Ouvrage
Go
-------------------------------------------------------------------Inserer une emprunt------------------------------------------------------

create procedure emprunterOuv(@idEmp nvarchar(50),@cote nvarchar(30),@semestre nvarchar(4),@datePrevoyer date)
as
insert into Emprunter (ID_Emprunteur,Cote,Semetre,Date_Retour_prevoyer) values(@idEmp,@cote,@semestre,@datePrevoyer)
Go
-------------------------------------------------------------------Ramener une emprunt------------------------------------------------------

create procedure Retourneremprunt(@code int)
as
update Emprunter set Date_Reteur_Reel=getdate(),retourne=1 where CodePret=@code
Go
-------------------------------------------------------------------returner la quantite valable------------------------------------------------------
Go
create function QteValable(@Cote nvarchar(30))
returns int
as
begin
declare @qte int
select @qte=Quantite from Quantite_Ouvrage_Disponible where Cote=@Cote
if(@qte is null)
set @qte=0;
return @qte
end
Go
-------------------------------------------------------------------Les emprunt non retournee------------------------------------------------------
create function LesEmpruntAretournee()
returns table
as
return(
select CodePret,Cote,Emprunter.ID_Emprunteur,Nom,Prenom,Sexe,DateEmprunt,Date_Retour_prevoyer from Emprunter inner join Emprunteur on
Emprunter.ID_Emprunteur=Emprunteur.ID_Emprunteur  where retourne=0
)
Go
-------------------------------------------------------------------Les Statistiques------------------------------------------------------
 
-------------------------------------------------------------------Par emprunteur------------------------------------------------------
create function statistiqueParEmp(@date1 date ,@date2 date,@s nvarchar(50))
returns @statistique table (
nb int,
idType int,
TypeEmp nvarchar(60),
ID nvarchar(50),
Nom nvarchar(30),
Prenom nvarchar(30),
sexe nvarchar(1),
filier nvarchar(10)
)
as
begin
insert into @statistique select count(CodePret),Emprunteur.IdTypeEmp,
TypeEmprunteur.Dèsignation,Emprunteur.ID_Emprunteur,Nom,Prenom,Sexe,
CodeFilier from Emprunter inner join 
Emprunteur on Emprunteur.ID_Emprunteur=Emprunter.ID_Emprunteur inner join TypeEmprunteur 
on Emprunteur.IdTypeEmp=TypeEmprunteur.IdTypeEmp where DateEmprunt between @date1 and @date2 and
Semetre in (select * from [dbo].[separer](@s))  group by Emprunteur.ID_Emprunteur,
Nom,Prenom,Sexe,CodeFilier,Emprunteur.IdTypeEmp,TypeEmprunteur.Dèsignation order by
 count(CodePret) desc
return 
end
Go
-------------------------------------------------------------------Par document------------------------------------------------------
create function statistiqueParDoc(@date1 date ,@date2 date,@s nvarchar(50))
returns @statistique table (
nb int,
Cote nvarchar(30),
titre nvarchar(200),
auteur nvarchar(150),
TypeDoc nvarchar(60),
domain nvarchar(80),
Sdomain nvarchar(80)
)
as
begin
insert into @statistique  select count(CodePret),Ouvrage.Cote,Titre,Auteur,TypeOuvrage,
Domaine,SousDomaine from Ouvrage inner join Emprunter on Ouvrage.Cote=Emprunter.cote  where DateEmprunt between @date1 and @date2 and
Semetre in (select * from [dbo].[separer](@s)) group by Ouvrage.Cote,Titre,Auteur,TypeOuvrage,
Domaine,SousDomaine  order by count(CodePret) desc
return 
end
Go
-------------------------------------------------------------------Par domaine------------------------------------------------------
create function statistiqueParDomaine(@date1 date ,@date2 date,@s nvarchar(50))
returns @statistique table (
domain nvarchar(80),
nb int
)
as
begin
insert into @statistique  select Domaine,count(CodePret) from Ouvrage 
inner join Emprunter on Ouvrage.Cote=Emprunter.cote where DateEmprunt between @date1 and @date2 and
Semetre in (select * from [dbo].[separer](@s)) group by 
Domaine  order by count(CodePret) desc
return 
end
Go

Go-------------------------------------------------------------------retourner les semestre sous form d'un table------------------------------------------------------
create FUNCTION [dbo].[separer]
(@Param nvarchar(50))
RETURNS @Values TABLE (Params nvarchar(4))AS
BEGIN
DECLARE @chrind INT
DECLARE @Piece nvarchar(4)
SELECT @chrind = 1 
WHILE @chrind > 0
BEGIN
  SELECT @chrind = CHARINDEX(',',@Param)
  IF @chrind  > 0
    SELECT @Piece = LEFT(@Param,@chrind - 1)
  ELSE
    SELECT @Piece = @Param
  INSERT  @Values(Params) VALUES(CAST(@Piece AS nVARCHAR(4)))
  SELECT @Param = RIGHT(@Param,LEN(@Param)- @chrind)
  IF LEN(@Param) = 0 BREAK
END
RETURN
END

-------------------------------------------------------------------TEST>>>>>>>>>>>>>>>TEST>>>>>>>>>>>>>>>>TEST------------------------------------------------------
Go
------------------------------------------select----------------------------------
select * from LesSanctionnes
select * from TypesOuvrage
select * from Domaine
select * from SousDomaine
select * from Auteur
select * from Ouvrage
select * from Quantite_Ouvrage_Disponible
select * from TypeEmprunteur
select * from Filier
select * from Emprunteur
select * from Emprunter
select * from Emprunteur_Sanctionne
------------------------------------------delete-----------------------------------
delete from Ouvrage
delete from Quantite_Ouvrage_Disponible
delete from Filier
delete from Emprunteur
delete from Emprunter
delete from Emprunteur_Sanctionne

drop table Emprunteur_Sanctionne
drop table Emprunter
drop table Emprunteur
drop table Filier
drop table Quantite_Ouvrage_Disponible
drop table Ouvrage
drop table TypeEmprunteur
Go
------------------------------------------attacher & dettacher la base de donnees------------------------------------------------------

EXEC sp_attach_db @dbname = @NOM_De_BD,
    @filename1 =@NomFichier1,
    @filename2 = @NomFichier2;
Go
EXEC sp_detach_db @dbname = 'Database1' 
-------------------------------------------'allow remote connection' ---------------------------------------------------
exec sp_configure 'remote access',1; 
Go
reconfigure with override 
Go
--create login login1 with PASSWORD = '1234567890'
--Go
--create user user1 for login login1
--Go
--grant execute to user1
--Go
--grant select to user1
--Go
--grant insert to user1
--Go
--grant update to user1
--Go
--grant delete to user1