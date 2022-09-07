CREATE TABLE [dbo].[Levels]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Level_name] TEXT NOT NULL, 
	[Level_type] TEXT NOT NULL  
)
CREATE TABLE [dbo].[PaymentType]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Payment_name] TEXT NOT NULL, 
	[Price] INT NOT NULL  
)
CREATE TABLE [dbo].[Groups]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Group_name] TEXT NOT NULL 
)
CREATE TABLE [dbo].[Halls]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Hall_name] TEXT NOT NULL,
	[Address] TEXT NULL
)
CREATE TABLE [dbo].[Seminars]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Instructor_name] TEXT NOT NULL,
	[Place] TEXT NULL,
	[City] TEXT NOT NULL,
	[Start_date] DATE NOT NULL,
	[End_date] DATE NOT NULL
)
CREATE TABLE [dbo].[Exams]
(
	[Kartoteka] CHAR(10) NOT NULL,
	[Level] INT NOT NULL,
	[Exam_day] TEXT NULL,
	[Examiner] TEXT NOT NULL,
	
)
CREATE TABLE [dbo].[SeminarParticipation]
(
	[Kartoteka] CHAR(10) NOT NULL,
	[Seminar] INT NOT NULL	
)
CREATE TABLE [dbo].[GroupList]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[Kartoteka] CHAR(10) NOT NULL,
	[Group_name] INT NOT NULL	
)
CREATE TABLE [dbo].[Timetable]
(
	[Instructor] CHAR(10) NOT NULL,
	[Grouplist] INT NOT NULL,
	[Hall] INT NOT NULL,
	[Weekday] TEXT NOT NULL,
	[Start_time] TIME NOT NULL,
	[Duration] INT NOT NULL,
)
CREATE TABLE [dbo].[Parents]
(
	[ID] INT NOT NULL PRIMARY KEY,
	[First_name] TEXT NOT NULL, 
	[Middle_name] TEXT NULL ,
    [Last_name] TEXT NOT NULL ,
	[Telephone] TEXT NULL ,
	[Email_] TEXT NULL,
	[Kartoteka] CHAR(10) NOT NULL
)
CREATE TABLE [dbo].[PaymentDetails]
(	
	[Payment_type] INT NOT NULL,
	[Payment] INT NOT NULL
)

CREATE TABLE [dbo].[Payment]
(	
	[ID] INT NOT NULL PRIMARY KEY,
	[Kartoteka] CHAR(10) NOT NULL,
	[Pay_date] DATE NULL ,
    [Pay_month] TEXT NOT NULL 
)
ALTER TABLE dbo.Exams
   ADD CONSTRAINT FK_Exams_Kartotekas FOREIGN KEY (Kartoteka)
      REFERENCES dbo.Kartoteki (EGN)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.SeminarParticipation
   ADD CONSTRAINT FK_Participation_Kartoteka FOREIGN KEY (Kartoteka)
      REFERENCES dbo.Kartoteki (EGN)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.SeminarParticipation
   ADD CONSTRAINT FK_Participation_Seminars FOREIGN KEY (Seminar)
      REFERENCES dbo.Seminars (ID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.GroupList
   ADD CONSTRAINT FK_Group_Kartoteka FOREIGN KEY (Kartoteka)
      REFERENCES dbo.Kartoteki (EGN)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.GroupList
   ADD CONSTRAINT FK_Group_List FOREIGN KEY (Group_name)
      REFERENCES dbo.Groups (ID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.Timetable
   ADD CONSTRAINT FK_Timetable_Instructor FOREIGN KEY (Instructor)
      REFERENCES dbo.Kartoteki (EGN)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.Timetable
   ADD CONSTRAINT FK_Timetable_Group FOREIGN KEY (Grouplist)
      REFERENCES dbo.GroupList (ID)
      ON DELETE NO ACTION
      ON UPDATE NO ACTION
;
ALTER TABLE dbo.Timetable
   ADD CONSTRAINT FK_Timetable_Hall FOREIGN KEY (Hall)
      REFERENCES dbo.Halls (ID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.PaymentDetails
   ADD CONSTRAINT FK_Payment_type FOREIGN KEY (Payment_type)
      REFERENCES dbo.PaymentType (ID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.Payment
   ADD CONSTRAINT FK_Payment_kartoteka FOREIGN KEY (Kartoteka)
      REFERENCES dbo.Kartoteki (EGN)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;
ALTER TABLE dbo.PaymentDetails
   ADD CONSTRAINT FK_Payment_details FOREIGN KEY (Payment)
      REFERENCES dbo.Payment (ID)
      ON DELETE CASCADE
      ON UPDATE CASCADE
;