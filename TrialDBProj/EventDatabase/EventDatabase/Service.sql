CREATE TABLE [dbo].[Service]
(
	[ServiceId] INT IDENTITY NOT NULL ,
    [EventUserId] INT NOT NULL, 
    [Description] VARCHAR(200) NOT NULL, 
    [Category] VARCHAR(50) NOT NULL,  
    [FromTime] TIME NOT NULL, 
    [ToTime] TIME NOT NULL, 
    [FromDate] DATE NOT NULL, 
    [ToDate] DATE NOT NULL,
	PRIMARY KEY CLUSTERED ([ServiceId] ASC),
	CONSTRAINT [FK_dbo.Service_dbo.EventUser_EventUserId] FOREIGN KEY ([EventUserId])
		REFERENCES [dbo].[EventUser] ([EventUserId]) ON DELETE NO ACTION
)
