CREATE DATABASE HeadHuntReview;
GO
USE HeadHuntReview;
GO

CREATE TABLE Candidates
(
  Id       INT IDENTITY PRIMARY KEY,
  Name     VARCHAR(50),
  Industry VARCHAR(50),
  Stars    INT
)
GO

CREATE UNIQUE INDEX Candidates_Id_uindex
  ON Candidates (Id)
GO

CREATE TABLE Company
(
  Id   INT IDENTITY PRIMARY KEY,
  Name VARCHAR(50),
  Title VARCHAR(50)
)
GO

CREATE UNIQUE INDEX Company_Id_uindex
  ON Company (Id)
GO

CREATE TABLE Reviews
(
  Id          INT IDENTITY PRIMARY KEY,
  Title       VARCHAR(50),
  Blurb       VARCHAR(50),
  Stars       INT,
  Date        DATETIME,
  RecruiterId INT,
  CandidateId INT
)
GO

CREATE UNIQUE INDEX Reviews_Id_uindex
  ON Reviews (Id)
GO

CREATE TABLE Recruiters
(
  Id        INT IDENTITY PRIMARY KEY,
  Name      VARCHAR(50),
  Company   VARCHAR(50),
  CompanyId INT
)
GO

SET IDENTITY_INSERT Recruiters ON
GO

INSERT INTO Recruiters (Id, Name, Company, CompanyId)
VALUES (1, 'Ken Hoinsky', 'Tek Systems Inc', 1)

INSERT INTO Recruiters (Id, Name, Company, CompanyId)
VALUES (2, 'Bob Villa', 'Tek Systems Inc', 1)

INSERT INTO Recruiters (Id, Name, Company, CompanyId)
VALUES (3, 'Magic Man', 'Bruno Mars Inc', 2)

INSERT INTO Recruiters (Id, Name, Company, CompanyId)
VALUES (4, 'Method Man', 'Bruno Mars Inc', 2)


SET IDENTITY_INSERT Recruiters OFF
GO


CREATE UNIQUE INDEX Recruiters_Id_uindex
  ON Recruiters (Id)
GO




