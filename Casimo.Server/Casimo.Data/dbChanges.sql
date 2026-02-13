-- List of assessments
CREATE TABLE tblAssessmentList(
    ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- ID is the unique identifier (Primary Key)
    ListName NVARCHAR(255) NULL,
    Description NVARCHAR(MAX) NULL,
    Active BIT NOT NULL DEFAULT 1,
    DateAdded DATETIME NOT NULL DEFAULT GETDATE()
);

-- Create an assessment list. Used to link users to their list of assessments
CREATE TABLE tblAssessmentListAssessments(
    ListID INT NOT NULL,
    LogID INT NOT NULL,
    DateAdded DATETIME NOT NULL DEFAULT GETDATE(),
    PRIMARY KEY (ListID, LogID), -- Composite Primary Key is the unique identifier
    FOREIGN KEY (ListID) REFERENCES tblAssessmentList(ID),
    FOREIGN KEY (LogID) REFERENCES tblFFPasstLog(ID)
);

CREATE INDEX IX_tblAssessmentListAssessments_LogID ON tblAssessmentListAssessments (LogID);

-- Assigns a specific assessment list to a user.
-- This tracks which lists a user has been assigned and when.
CREATE TABLE tblUserAssignedAssessmentLists(
    AssignmentID INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- AssignmentID is the unique identifier (Primary Key)
    UserID INT NOT NULL,
    ListID INT NOT NULL,
    DateAssigned DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (UserID) REFERENCES tblUsers(UserID),
    FOREIGN KEY (ListID) REFERENCES tblAssessmentList(ID)
);

-- Index for efficient lookups/joins when finding all lists assigned to a specific user.
CREATE INDEX IX_tblUserAssignedAssessmentLists_UserID ON tblUserAssignedAssessmentLists (UserID);

-- Index for efficient lookups/joins when finding all users assigned a specific list.
CREATE INDEX IX_tblUserAssignedAssessmentLists_ListID ON tblUserAssignedAssessmentLists (ListID);

-- Create table which hold the status of an FFPAssessmentLog 
CREATE TABLE tblAssessmentStatus(
	ID int not null,
	Name varchar(100) not null,
	Description varchar(255) not null,
	PRIMARY KEY (ID)
)

-- Insert default values into the database
INSERT INTO [dbo].[tblAssessmentStatus]([ID],[Name],[Description])VALUES(1, 'New', 'No changes have been made to a new blank assessment by the user');
INSERT INTO [dbo].[tblAssessmentStatus]([ID],[Name],[Description])VALUES(2, 'InProgress', 'Changes have been made to a new assessment. A draft may have been saved or The initial assessment has NOT yet been submitted for review');
INSERT INTO [dbo].[tblAssessmentStatus]([ID],[Name],[Description])VALUES(3, 'AdminReview', 'The user has submitted the draft for review by the admin. The admin will make changes to it in this state.');
INSERT INTO [dbo].[tblAssessmentStatus]([ID],[Name],[Description])VALUES(4, 'UserReview', 'The admin has made changes then returned it to the user for final review');
INSERT INTO [dbo].[tblAssessmentStatus]([ID],[Name],[Description])VALUES(5, 'Completed', 'The admin has closed off the assessment and no further changes will be made by the user');

-- Add the StatusId column to tblFFPasstLog
ALTER TABLE tblFFPasstLog
ADD StatusId INT NOT NULL DEFAULT 5;

-- Create an index
CREATE INDEX IX_tblFFPasslog_StatusId ON tblFFPasstLog (StatusId);

-- Drop the existing default constraint (the one set to 4)
-- Find the system-generated name of the constraint first
DECLARE @ConstraintName nvarchar(256)
SELECT @ConstraintName = name
FROM sys.default_constraints
WHERE parent_object_id = OBJECT_ID('tblFFPasstLog') AND col_name(parent_object_id, parent_column_id) = 'StatusId';

IF @ConstraintName IS NOT NULL
    EXEC('ALTER TABLE tblFFPasstLog DROP CONSTRAINT ' + @ConstraintName);

-- Add the new default constraint, ensuring NEW records are 'New' (ID 1)
ALTER TABLE tblFFPasstLog
ADD CONSTRAINT DF_tblFFPasstLog_StatusId
DEFAULT 1 FOR StatusId;

-- Add last edited by columns
ALTER TABLE tblFFPasstLog 
ADD LastEdited DATETIME NULL; 
ALTER TABLE tblFFPasstLog 
ADD LastEditedBy varchar(255) null; 

-- Add the foreign key constraint
ALTER TABLE tblFFPasstLog
ADD CONSTRAINT FK_FFPasstLog_AssessmentStatus
FOREIGN KEY (StatusId) REFERENCES tblAssessmentStatus(ID);

-- Add a link to the identity db. 
ALTER TABLE tblUsers
ADD IdentityID nvarchar(450);
ALTER TABLE tblUsers 
ADD  IsTempUser BIT DEFAULT NULL; 

--alter table tblAssessmentStatus 
--add Description varchar(255) not null 
--default '';

---- Update default values in the database
--UPDATE [dbo].[tblAssessmentStatus] 
--SET [Name] = 'New', [Description] = 'No changes have been made to a new blank assessment by the user' 
--WHERE [ID] = 1;

--UPDATE [dbo].[tblAssessmentStatus] 
--SET [Name] = 'InProgress', [Description] = 'Changes have been made to a new assessment. A draft may have been saved or The initial assessment has NOT yet been submitted for review' 
--WHERE [ID] = 2;

--UPDATE [dbo].[tblAssessmentStatus] 
--SET [Name] = 'AdminReview', [Description] = 'The user has submitted the draft for review by the admin. The admin will make changes to it in this state.' 
--WHERE [ID] = 3;

--UPDATE [dbo].[tblAssessmentStatus] 
--SET [Name] = 'UserReview', [Description] = 'The admin has made changes then returned it to the user for final review' 
--WHERE [ID] = 4;

--UPDATE [dbo].[tblAssessmentStatus] 
--SET [Name] = 'Completed', [Description] = 'The admin has closed off the assessment and no further changes will be made by the user' 
--WHERE [ID] = 5;