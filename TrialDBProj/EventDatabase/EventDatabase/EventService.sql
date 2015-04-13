CREATE TABLE [dbo].[EventService]
(
	[EventServiceId] INT IDENTITY NOT NULL , 
    [EventId] INT NOT NULL, 
    [ServiceId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([EventServiceId] ASC),
	CONSTRAINT [FK_dbo.EventService_dbo.Event_EventId] FOREIGN KEY ([EventId])
	REFERENCES [dbo].[Event] ([EventId]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.EventService_dbo.Service_ServiceId] FOREIGN KEY ([ServiceId])
	REFERENCES [dbo].[Service] ([ServiceId]) ON DELETE CASCADE
)
