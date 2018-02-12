CREATE DATABASE HeadHuntReview;
GO
USE HeadHuntReview;
GO


CREATE TABLE Recruiters
(
  Id        INT IDENTITY PRIMARY KEY,
  Name      VARCHAR(50),
  Company   VARCHAR(50),
  Location  VARCHAR(50),
  ZipCode   VARCHAR(10),
  Stars     INT,
  Level     VARCHAR(10),
  CompanyId INT
)
GO

SET IDENTITY_INSERT Recruiters ON
GO

INSERT INTO Recruiters (Id, Name, Company, Location, ZipCode, Stars, Level,  CompanyId)
VALUES (1, 'Ken Hoinsky', 'Tek Systems Inc', 'Tokyo, Japan', '78704', 3, 'Senior', 1)

INSERT INTO Recruiters (Id, Name, Company, Location, ZipCode, Stars, Level,  CompanyId)
VALUES (2, 'Bob Villa', 'Tek Systems Inc', 'New York, NY', '19120', 4, 'Intermediate', 1)

INSERT INTO Recruiters (Id, Name, Company, Location, ZipCode, Stars, Level,  CompanyId)
VALUES (3, 'Magic Man', 'Bruno Mars Inc',  'Austin, TX', '78704', 5, 'Junior', 2)

INSERT INTO Recruiters (Id, Name, Company, Location, ZipCode, Stars, Level,  CompanyId)
VALUES (4, 'Method Man', 'Bruno Mars Inc',  'Austin, TX', '78704', 2, 'Junior', 2)


SET IDENTITY_INSERT Recruiters OFF
GO


CREATE UNIQUE INDEX Recruiters_Id_uindex
  ON Recruiters (Id)
GO


CREATE TABLE Candidates
(
  Id       INT IDENTITY PRIMARY KEY,
  Name     VARCHAR(50),
  Industry VARCHAR(50),
  ZipCode  VARCHAR(10),
  Stars    INT
)
GO

SET IDENTITY_INSERT Candidates ON
GO

INSERT INTO Candidates (Id, Name, Industry, ZipCode, Stars)
VALUES (1, 'Method Man', 'Technology', '78704', 4)

INSERT INTO Candidates (Id, Name, Industry, ZipCode, Stars)
VALUES (2, 'Raekwon', 'Technology', '78704', 4)

INSERT INTO Candidates (Id, Name, Industry, ZipCode, Stars)
VALUES (3, 'RZA', 'Financial', '78704', 3)

INSERT INTO Candidates (Id, Name, Industry, ZipCode, Stars)
VALUES (4, 'GZA', 'Financial', '78704', 3)

SET IDENTITY_INSERT Candidates OFF
GO

CREATE UNIQUE INDEX Candidates_Id_uindex
  ON Candidates (Id)
GO

CREATE TABLE Company
(
  Id   INT IDENTITY PRIMARY KEY,
  Name VARCHAR(50),
  Industry VARCHAR(50),
  Location VARCHAR(50),
  Stars    INT
)
GO

SET IDENTITY_INSERT Company ON
GO

INSERT INTO Company (Id, Name, Industry, Location, Stars)
VALUES (1, 'Tek Systems', 'Technology', 'Austin, TX', 3)

INSERT INTO Company (Id, Name, Industry, Location, Stars)
VALUES (2, 'Robert Half Technology', 'Financial', 'Austin, TX', 4)

INSERT INTO Company (Id, Name, Industry, Location, Stars)
VALUES (3, 'Bonus Staffing', 'Technology', 'New York, NY', 3)

INSERT INTO Company (Id, Name, Industry, Location, Stars)
VALUES (4, 'GoGo Placements', 'IT Consulting', 'Chicago, IL', 4)

SET IDENTITY_INSERT Company OFF
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





