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

INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2005, '488C6CEB-D092-41E2-A565-E99ABE795941', 'Arc Staffing', 'www.arc-staffing.com', 'Technology', '211 Waterford Centre Blvd', ' Ste. 125', 'Austin', 'TX', '78758');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2006, '7762C6BA-46BB-4F56-A7EA-03E702D7A422', 'Apricity, LLC', 'https://www.linkedin.com/company/apricity-llc/', 'default', '3809 S. Congress Ave', '#353', 'Austin', 'Texas (TX)', '78704');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2007, 'E4ED3053-C422-4C3A-A35A-2458E89FC3BB', 'IR Talent', 'www.irtalent.com', 'default', '1010 Brazos Street', '', 'Austin', 'Texas (TX)', '78701');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2008, '29ECE23D-024C-4C26-9609-AE7479577058', 'Macate Group', 'https://macate.com/', 'Recruiting', '6201 America Center Dr Suite ', '#220', 'San Jose', 'California', '95002');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2009, 'A126E71A-AF8A-4E45-A861-277B9F1401C2', 'Modis', 'modis.com', 'Recruiting', '9442 N Capital of Texas Hwy', '', 'Austin', 'Texas (TX)', '78759');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2010, '5481866C-4AE7-4706-AD7C-FC1CFC989179', 'Pedley-Richard', 'https://www.pedley-richard.com/', 'Recruiting', '279 River Oaks Drive', '', 'Cedar Creek', 'Texas (TX)', '78612');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2011, 'A17CE076-774F-4E6F-92F3-AAAE0E5BA3AF', 'Recruitability', 'https://www.therecruitability.com/', 'Recruiting', '300 E. Highland Mall Blvd', 'Ste. 305', 'Austin', 'Texas (TX)', '78752');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2012, 'D2D61A01-303A-4506-B414-2B6701C22BA4', 'Millennium Consulting', 'https://millennium-consulting.com', 'Recruiting', '26 Patriot Place', 'Suite 101', 'Foxborough', 'Massachusetts', '02035');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2013, 'A56F650B-89B1-444A-8167-B1FDAE486B69', 'Quest Groups', 'www.questgroups.com', 'Recruiting', '755 W. Front St', 'Ste 200', 'Boise', 'Idaho', '83702');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2014, '6E06A3D6-79BC-4508-ADCD-E7D94C59D585', 'Next Step Staffing', 'nsstaff.com', 'Recruiting', '902 Broadway ', '6th Floor', 'New York', 'NY', '10010');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2015, '144707ED-133C-423C-B5F7-E3688C634DBE', 'The Goal', 'http://www.thegoalinc.com', 'Recruiting', '11921 Freedom Drive', 'Suite 920', 'Reston', 'Virginia', '20190');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2016, '6A48121B-ED32-4B96-BBF1-640A982A0D9F', 'Advantage Resourcing', 'https://www.advantageresourcing.com', 'Recruiting', '220 Norwood Park S', '', 'Norwood', 'Massachusetts', '02062');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2017, 'B80DCE24-D943-42C6-A6B4-70E8CD130DB7', 'CoStar Group Inc', 'http://www.costargroup.com/', 'Recruiting', '100 Congress Ave', '', 'Austin', 'Texas (TX)', '78701');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2018, '9768D573-4716-4A90-9A7E-191E7382BACC', 'Optomi', 'https://optomi.com/', 'Recruiting', '500 Colonial Center Parkway', '#140', 'Roswell', 'GA', '30076');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2019, '34C44DA2-5CD2-4F05-BE43-E6FBB5408022', 'Venator Partners', 'http://www.venatorpartners.com/', 'Recruiting', '1035 Pearl Street', '', 'Boulder', 'Colorado', '80302');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2020, 'D56ADBF6-830A-4CA9-A1D5-32015366ECC4', 'Tekk Fusion', 'www.tekkfusion.com', 'Recruiting', '189 S Orange Ave,', '', 'Orlando', 'Florida', '32801');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2021, '087B5E3D-83FE-40C8-B2FB-1465FD937B28', 'Robert Half Technology', 'https://www.roberthalf.com/', 'Recruiting', '10801 N Mopac Expy', 'Bldg 2-220', 'AUSTIN', 'Texas (TX)', '78759');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2022, '87379FB9-C0B6-4254-AF27-2990A459E15A', 'Intersys Consulting, Inc', 'www.intersysconsulting.com', 'Recruiting', '504 Oakland Ave', '', 'Austin', 'Texas (TX)', '78703');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2023, '13025D6C-A56B-4A94-812D-4134E94A67FB', 'Randstad Technologies', 'https://www.randstadusa.com/', 'Recruiting', '8310 N Capital of Texas Hwy', 'Suite 220', 'AUSTIN', 'Texas (TX)', '78731');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2024, 'D9A6E4FC-3A95-4667-915E-4B58BF3F50AE', 'Cypress HCM', 'http://www.cypresshcm.com/', 'Recruiting', '2121 N California Blvd', '', 'Walnut Creek,', 'California', '94596');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2025, '5A4E4248-2BA3-4468-BB44-0F1CE1AE843D', 'Austin Fraser', 'https://www.austinfraser.com/en-us/', 'Recruiting', '500 W 2nd St Floor 15', 'Suite 1550', 'Austin', 'Texas (TX)', '78701');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2026, '38F5E26C-7A61-49F1-9D1C-0BD538618CB9', 'EXTEN Technologies, Inc', 'www.exten.io', 'Recruiting', '4201 W Parmer Ln', 'Bldg A', 'Austin', 'Texas (TX)', '78727');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2027, 'DBD20BA3-0B3A-428E-AE89-9CB462481261', 'WilsonHCG', 'https://www.wilsonhcg.com/', 'Recruiting', 'Rivergate Tower, 400 N Ashley Dr', '#3000', 'Tampa', 'Florida', '33602');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2028, '23DA50A4-EA0D-4FE6-8939-444C4B72A932', 'StoneWood Group', 'https://www.stonewoodgroup.com', 'Recruiting', '350 Palladium Dr #104', '', 'Kanata, ON', 'Canada', 'K2V 1A8');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2029, '8F280EEC-8D6F-4220-B29E-5D32F27DDCC7', 'Kforce Inc', 'https://www.kforce.com/', 'Recruiting', '1001 E. Palm Ave', '', 'Tampa', 'Florida', '33605');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2030, '73BB651A-3688-471A-A0F3-B1C4629EB1BB', 'Computer Futures', 'https://www.computerfutures.com/', 'Recruiting', '600 Congress Avenue', '16th Floor', 'Austin', 'Texas (TX)', '78701');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2031, '7942A06E-078C-462B-B598-C8C4E7C86093', 'Genuent Staffing and IT Services', 'www.genuent.net', 'Recruiting', '3800 North Lamar Blvd', 'Suite 200', 'Austin', 'Texas (TX)', '78756');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2032, 'DBACF4FD-E3D2-4A61-854C-F932F5074973', 'Brooksource', 'https://www.brooksource.com/', 'Recruiting', '3755 S Capital of Texas Hwy', '#200', 'Austin', 'Texas (TX)', '78704');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2033, '352A6E0E-478F-436D-9416-06763A80086B', 'BBG Management Corporation', 'http://www.bbgmanagement.com/', 'Recruiting', '204-112 Nelson Street', '', 'Ottawa', 'Ontario', 'K1N 7R5');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2034, '5A466864-7AEB-4E7F-B656-601BAA27A49D', 'Man Power Group', 'www.manpowergroup.com', 'Recruiting', '100 Manpower Place', '', 'Milwaukee', 'Wisconsin', '53212');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2035, '613EECCB-F924-435B-B96B-B46242BFC59D', 'Zilker Partners', 'https://zilkerpartners.com/', 'Recruiting', '2700 W Anderson Ln', 'Suite 121', 'Austin', 'Texas (TX)', '78757');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2036, 'B5203B29-72C9-4EB7-9759-51EFDA7F6B16', 'Luna Data Solutions', 'http://www.lunadatasolutions.com/', 'Recruiting', '1408 W Koenig Ln', '', 'Austin', 'Texas (TX)', '78756');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2037, 'D499A8C9-0CB6-4E38-BF4E-61A90D122C2C', 'Insight Global', 'https://www.insightglobal.com/', 'Recruiting', '401 Congress Ave', 'Suite 1600', 'Austin', 'Texas (TX)', '78701');
INSERT INTO HeadHuntReview.dbo.Company (Id, UniqueId, Name, Url, Industry, Address1, Address2, City, State, ZipCode) VALUES (2038, '1278067D-C559-4BCE-8C06-1436F9F67E47', 'E-Solutions Inc', 'http://www.e-solutionsinc.com/', 'Recruiting', '2 North Market Street', 'Suite #400', 'San Jose', 'California', '95113');

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
  Title     VARCHAR(50),
  LinkedIn  VARCHAR(250),
  Email     VARCHAR(50),
  Stars     INT,
  Level     VARCHAR(20),
  CompanyId INT FOREIGN KEY REFERENCES Company(Id),
)
GO

SET IDENTITY_INSERT Recruiters ON
GO

INSERT INTO Recruiters (Id, UniqueId, Name, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (1, NEWID(), 'Ken Hoinsky', 'Lead Recruiter', 'https://www.linkedin.com/in/richarddalfonso/', 'ken@crunchyroll.com', 3, 'Senior', 2)

INSERT INTO Recruiters (Id, UniqueId, Name, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (2, NEWID(), 'Bob Villa',  'Junior Recruiter', 'https://www.linkedin.com/in/richarddalfonso/', 'ken@crunchyroll.com', 4, 'Intermediate', 2)

INSERT INTO Recruiters (Id, UniqueId, Name, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (3, NEWID(), 'Magic Man', 'Senior Executive', 'https://www.linkedin.com/in/richarddalfonso/','ken@crunchyroll.com', 5, 'Junior', 4)

INSERT INTO Recruiters (Id, UniqueId, Name, Title, LinkedIn, Email, Stars, Level,  CompanyId)
VALUES (4, NEWID(), 'Method Man', 'Lead Headhunter', 'https://www.linkedin.com/in/richarddalfonso/', 'ken@crunchyroll.com', 2, 'Junior', 4)


SET IDENTITY_INSERT Recruiters OFF
GO


CREATE UNIQUE INDEX Recruiters_Id_uindex
  ON Recruiters (Id)
GO


CREATE TABLE Candidates
(
  Id        INT IDENTITY PRIMARY KEY,
  UniqueId  uniqueidentifier,
  Name      VARCHAR(50),
  Industry  VARCHAR(50),
  Email     VARCHAR(20),
  ExperienceYrs INT,
  FbUid     VARCHAR(50),
)
GO

SET IDENTITY_INSERT Candidates ON
GO


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
  Body        text,
  Stars       INT,
  Date        DATETIME,
  RecruiterId INT FOREIGN KEY REFERENCES Recruiters(Id),
  CandidateId INT FOREIGN KEY REFERENCES Candidates(Id)
)
GO

SET IDENTITY_INSERT Reviews ON
GO

INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CandidateId) 
VALUES (1, NEWID(), 'Worst Manners', 'Dude is horrible', 2, getdate(), 1, 1)

INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CandidateId) 
VALUES (2, NEWID(), 'Awful Manners', 'Dude is horrible', 2, getdate(), 1, 2) 
INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CandidateId)
 VALUES (3, NEWID(), 'Annoying Personality', 'Recruiter is obnoxious', 2, getdate(), 3, 3) 
INSERT INTO Reviews (Id, UniqueId, Title,  Body, Stars, Date, RecruiterId, CandidateId) 
VALUES (4, NEWID(), 'Rock Star', 'Everything he promised came true.', 5, getdate(), 4, 4)

SET IDENTITY_INSERT Reviews OFF
GO

CREATE UNIQUE INDEX Reviews_Id_uindex
  ON Reviews (Id)
GO





