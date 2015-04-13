CREATE TABLE [dbo].[EventUser]
(
	[EventUserId] INT IDENTITY NOT NULL  PRIMARY KEY, 
    [Fname] VARCHAR(50) NOT NULL, 
    [Lname] VARCHAR(50) NOT NULL, 
    [CompName] VARCHAR(50) NULL, 
    [Phone] VARCHAR(50) NOT NULL,
	[Email]	VARCHAR(50) NOT NULL,
	[Website] VARCHAR(50) NULL, 
    [Address1] VARCHAR(50) NULL, 
    [Address2] VARCHAR(50) NULL, 
    [Town] VARCHAR(50) NULL, 
    [County] VARCHAR(50) NULL,
	[NumServives] int NULL, 
    [NumEvents] INT NULL, 
    [Biog] VARCHAR(500) NULL, 
    [ImagePath] VARCHAR(100) NULL
)


