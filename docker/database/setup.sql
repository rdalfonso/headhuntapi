CREATE DATABASE HeadHuntReview;
GO
USE HeadHuntReview;
GO


CREATE TABLE Company
(
  Id   INT IDENTITY PRIMARY KEY,
  UniqueId  uniqueidentifier,
  Name      VARCHAR(50),
  Url       VARCHAR(255),
  Industry  VARCHAR(50),
  Address1  VARCHAR(50),
  Address2  VARCHAR(50),
  City      VARCHAR(50),
  State     VARCHAR(20),
  ZipCode   VARCHAR(10)
)
GO

SET IDENTITY_INSERT Company ON
GO

INSERT INTO Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode)
VALUES (1, NEWID(), 'Tek Systems', 'https://www.roberthalf.com/', 'Technology', '1123A Bluebonnet Lane', '', 'Austin', 'TX', '78704')

INSERT INTO Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode)
VALUES (2, NEWID(), 'Robert Half Technology', 'https://www.roberthalf.com/', 'Technology', '1221 South Congress Ave', 'Suite 5', 'Austin', 'TX', '78704')

INSERT INTO Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode)
VALUES (3, NEWID(), 'Techies LLC', 'https://www.roberthalf.com/', 'Technology', '5645 Elbow Lane', '', 'Austin', 'TX', '78701')

INSERT INTO Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode)
VALUES (4, NEWID(), 'The Money Store','https://www.roberthalf.com/', 'Financial', '5645 Elbow Lane', '', 'Austin', 'TX', '78754')

SET IDENTITY_INSERT Company OFF
GO

CREATE UNIQUE INDEX Company_Id_uindex
  ON Company (Id)
GO


CREATE TABLE Recruiters
(
  Id        INT IDENTITY PRIMARY KEY,
  UniqueId  uniqueidentifier,
  Name      VARCHAR(50),
  Company   VARCHAR(50),
  Title     VARCHAR(50),
  LinkedIn  VARCHAR(250),
  Email     VARCHAR(50),
  Stars     INT,
  Level     VARCHAR(10),
  CompanyId INT
)
GO

SET IDENTITY_INSERT Recruiters ON
GO

INSERT INTO Recruiters (Id, UniqueId, Name, Company, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (1, NEWID(), 'Ken Hoinsky', 'Robert Half Technology', 'Lead Recruiter', 'https://www.linkedin.com/in/richarddalfonso/', 'ken@crunchyroll.com', 3, 'Senior', 2)

INSERT INTO Recruiters (Id, UniqueId, Name, Company, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (2, NEWID(), 'Bob Villa', 'Robert Half Technology', 'Junior Recruiter', 'https://www.linkedin.com/in/richarddalfonso/', 'ken@crunchyroll.com', 4, 'Intermediate', 2)

INSERT INTO Recruiters (Id, UniqueId, Name, Company, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (3, NEWID(), 'Magic Man', 'The Money Store',  'Senior Executive', 'https://www.linkedin.com/in/richarddalfonso/','ken@crunchyroll.com', 5, 'Junior', 4)

INSERT INTO Recruiters (Id, UniqueId, Name, Company, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (4, NEWID(), 'Method Man', 'The Money Store',  'Lead Headhunter', 'https://www.linkedin.com/in/richarddalfonso/', 'ken@crunchyroll.com', 2, 'Junior', 4)


SET IDENTITY_INSERT Recruiters OFF
GO


CREATE UNIQUE INDEX Recruiters_Id_uindex
  ON Recruiters (Id)
GO


CREATE TABLE Candidates
(
  Id       INT IDENTITY PRIMARY KEY,
  UniqueId  uniqueidentifier,
  Name     VARCHAR(50),
  Industry VARCHAR(50),
  Email  VARCHAR(20),
  ExperienceYrs    INT
)
GO

SET IDENTITY_INSERT Candidates ON
GO

INSERT INTO Candidates (Id, UniqueId, Name, Industry, Email, ExperienceYrs)
VALUES (1, NEWID(), 'Method Man', 'Technology', 'fakeguy@yahoo.com', 4)

INSERT INTO Candidates (Id, UniqueId, Name, Industry, Email, ExperienceYrs)
VALUES (2, NEWID(), 'Raekwon', 'Technology', 'fakeguy@yahoo.com', 4)

INSERT INTO Candidates (Id, UniqueId, Name, Industry, Email, ExperienceYrs)
VALUES (3, NEWID(), 'RZA', 'Financial', 'fakeguy@yahoo.com', 3)

INSERT INTO Candidates (Id, UniqueId, Name, Industry, Email, ExperienceYrs)
VALUES (4, NEWID(), 'GZA', 'Financial', 'fakeguy@yahoo.com', 3)

SET IDENTITY_INSERT Candidates OFF
GO

CREATE UNIQUE INDEX Candidates_Id_uindex
  ON Candidates (Id)
GO


CREATE TABLE Reviews
(
  Id          INT IDENTITY PRIMARY KEY,
  UniqueId    uniqueidentifier,
  Title       VARCHAR(50),
  Body       text,
  Stars       INT,
  Date        DATETIME,
  RecruiterId INT,
  CompanyId INT,
  CandidateId INT
)
GO

SET IDENTITY_INSERT Reviews ON
GO

INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CompanyId, CandidateId)
VALUES (1, NEWID(), 'Worst Manners', 'Dude is horrible', 2, getdate(), 1, 1, 1)

INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CompanyId, CandidateId)
VALUES (2, NEWID(), 'Inflated Salary', 'Recruiter made false claims', 2, getdate(), 1, 1, 2)

INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CompanyId, CandidateId)
VALUES (3, NEWID(), 'Annoying Personality', 'Recruiter is obnoxious', 2, getdate(), 2, 1, 3)

INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CompanyId, CandidateId)
VALUES (4, NEWID(), 'Rock Star', 'Everything he promised came true.', 5, getdate(), 2, 1, 4)

SET IDENTITY_INSERT Reviews OFF
GO

CREATE UNIQUE INDEX Reviews_Id_uindex
  ON Reviews (Id)
GO





