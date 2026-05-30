CREATE DATABASE ClinicDB;
GO

USE ClinicDB;
GO


-- =====================================
-- USERS TABLE
-- =====================================

CREATE TABLE Users
(
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL UNIQUE,
    Password VARCHAR(50) NOT NULL,
    Role VARCHAR(20) NOT NULL
);
GO


-- =====================================
-- PATIENTS TABLE
-- =====================================

CREATE TABLE Patients
(
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    FullName VARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Gender VARCHAR(20) NOT NULL,
    Address VARCHAR(150) NOT NULL,
    ContactNo VARCHAR(20) NOT NULL
);
GO


-- =====================================
-- CONSULTATIONS TABLE
-- =====================================

CREATE TABLE Consultations
(
    ConsultationID INT PRIMARY KEY IDENTITY(1,1),

    PatientID INT NOT NULL,

    Weight DECIMAL(5,2) NOT NULL,

    Height DECIMAL(5,2) NOT NULL,

    Symptoms VARCHAR(255),

    Diagnosis VARCHAR(255),

    BMI DECIMAL(5,2),

    ConsultationDate DATE DEFAULT GETDATE(),

    CONSTRAINT FK_PatientConsultation
    FOREIGN KEY (PatientID)
    REFERENCES Patients(PatientID)
    ON DELETE CASCADE
);
GO


-- =====================================
-- USER ACCOUNTS
-- =====================================

INSERT INTO Users
(
Username,
Password,
Role
)

VALUES

('admin','admin123','Admin'),
('user1','user123','Standard User');

GO


-- =====================================
-- PATIENT DATA
-- =====================================

INSERT INTO Patients
(
FullName,
Age,
Gender,
Address,
ContactNo
)

VALUES

('Juan Dela Cruz',25,'Male','Barangay 1, City','09123456789'),

('Maria Santos',30,'Female','Barangay 2, City','09098765432'),

('Pedro Reyes',40,'Male','Barangay 3, City','09111222333'),

('Ana Lopez',21,'Female','Barangay 4, City','09156789012'),

('Mark Mendoza',28,'Male','Barangay 5, City','09234567891'),

('Sofia Cruz',19,'Female','Barangay 6, City','09123456788'),

('Daniel Garcia',35,'Male','Barangay 7, City','09345678123'),

('Isabella Ramos',24,'Female','Barangay 8, City','09456781234'),

('John Reyes',31,'Male','Barangay 9, City','09567812345'),

('Claire Santos',27,'Female','Barangay 10, City','09678912345'),

('Michael Torres',42,'Male','Barangay 11, City','09177889900'),

('Patricia Lim',29,'Female','Barangay 12, City','09188990011'),

('Kevin Villanueva',23,'Male','Barangay 13, City','09299001122');

GO


-- =====================================
-- CONSULTATION DATA
-- =====================================

INSERT INTO Consultations
(
PatientID,
Weight,
Height,
Symptoms,
Diagnosis,
BMI
)

VALUES

(1,60,1.70,'Headache','Migraine',20.76),

(2,50,1.60,'Fever and Cough','Flu',19.53),

(3,75,1.75,'Chest Pain','Stress Related',24.49),

(4,48,1.55,'Dizziness','Low Blood Pressure',19.98),

(5,82,1.78,'Back Pain','Muscle Strain',25.88),

(6,45,1.60,'Fever','Viral Infection',17.58),

(7,70,1.68,'Headache','Migraine',24.80),

(8,65,1.72,'Cough','Respiratory Infection',21.97),

(9,75,1.80,'Chest Tightness','Stress Related',23.15),

(10,58,1.62,'Fatigue','Lack of Sleep',22.10),

(11,85,1.76,'High Blood Pressure','Hypertension',27.44),

(12,52,1.58,'Fever and Cough','Flu',20.83),

(13,68,1.70,'Stomach Pain','Acid Reflux',23.53);

GO


-- =====================================
-- REPORT VIEW
-- =====================================

CREATE VIEW PatientSummaryReport
AS

SELECT

p.PatientID,
p.FullName,
p.Age,
p.Gender,
p.ContactNo,
c.Diagnosis,
c.BMI,
c.ConsultationDate

FROM Patients p

LEFT JOIN Consultations c

ON p.PatientID=c.PatientID;

GO


-- =====================================
-- TEST QUERY
-- =====================================

SELECT * FROM Users;
SELECT * FROM Patients;
SELECT * FROM Consultations;
SELECT * FROM PatientSummaryReport;
GO
USE master;
GO
USE master;
DROP DATABASE ClinicDB;

DROP TABLE Users;

IF OBJECT_ID('Consultations', 'U') IS NOT NULL
    DROP TABLE Consultations;

IF OBJECT_ID('Patients', 'U') IS NOT NULL
    DROP TABLE Patients;

    IF OBJECT_ID('Patients', 'U') IS NOT NULL
    DROP VIEW PatientSummaryReport;