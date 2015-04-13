CREATE TABLE [dbo].[Event]
(
	[EventId] INT IDENTITY NOT NULL, 
    [EventUserId] INT NOT NULL, 
    [Description] VARCHAR(200) NOT NULL, 
    [Category] VARCHAR(50) NOT NULL, 
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NOT NULL, 
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NULL, 
    [Attendance] INT NULL,
	PRIMARY KEY CLUSTERED ([EventId] ASC),
	CONSTRAINT [FK_dbo.Event_dbo.EventUser_EventUserId] FOREIGN KEY ([EventUserId])
		REFERENCES [dbo].[EventUser] ([EventUserId]) on DELETE NO ACTION
)
