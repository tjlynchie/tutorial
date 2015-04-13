
MERGE INTO EventUser AS Target
USING (VALUES 
        (1, 'Derek', 'Caprani', 'DeeSee Venues', '087 9679097', 'dcaprani@me.com', 'www.deesee.ie', '554 Riverforest', 'Leixlip', 'Co Kildare'),
		(2, 'Thomas', 'Lynch', 'Toms Disco', '086 1362477', 'tomtom@tom.tom', 'www.tomstav.tom', '233 TomsCabin', 'TomTown', 'Co Cork'),
		(3, 'Aoife', 'Ní Guna', 'Unas Guna', '085 2549087', 'unaGuna@guna.gun', 'www.unaguna.gun', '111 GunaGirl', 'UnaGuna', 'Co Galway')
      ) 
AS Source (EventUserId, Fname, Lname, CompName, Phone, Email, Website, Address1, Town, County) 
ON Target.EventUserId = Source.EventUserId 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (Fname, Lname, CompName, Phone, Email, Website, Address1, Town, County) 
VALUES (Fname, Lname, CompName, Phone, Email, Website, Address1, Town, County);


MERGE INTO Service AS Target
USING (VALUES 
        (1, 1, 'Meeting Room', 'Venues', '09:00:00', '22:00:00', '2015-01-01', '2015-12-31'), 
        (2, 2, 'Disco Services with Dancing ', 'DJs', '20:00:00', '23:59:00', '2015-01-01', '2015-12-31'), 
		(3, 3, 'Fancy Dress Services', 'Costumes', '09:00:00', '18:00:00', '2015-01-01', '2015-12-31')
)
AS Source (ServiceId, EventUserId, Description, Category, FromTime, ToTime, FromDate, ToDate)
ON Target.ServiceId = Source.ServiceId
WHEN NOT MATCHED BY TARGET THEN
INSERT ( EventUserId, Description, Category, FromTime, ToTime, FromDate, ToDate)
VALUES ( EventUserId, Description, Category, FromTime, ToTime, FromDate, ToDate);

MERGE INTO Event AS Target
USING (VALUES 
        (1, 3, 'Marys Birthday Party', 'Party', '19:00:00', '23:00:00', '2015-06-06', '2015-06-06', 50), 
        (2, 2, 'Harrys Disco ', 'Dance', '20:00:00', '03:00:00', '2015-07-16', '2015-07-17', 200), 
		(3, 3, 'Twins Christening', 'Family', '13:00:00', '18:00:00', '2015-08-16', '2015-08-16', 20)
)
AS Source (EventId, EventUserId, Description, Category, StartTime, EndTime, StartDate, EndDate, Attendance)
ON Target.EventId = Source.EventId
WHEN NOT MATCHED BY TARGET THEN
INSERT ( EventUserId, Description, Category, StartTime, EndTime, StartDate, EndDate, Attendance)
VALUES ( EventUserId, Description, Category, StartTime, EndTime, StartDate, EndDate, Attendance);

MERGE INTO EventService AS Target
USING (VALUES 
	(1, 1, 1),
	(2, 1, 2),
	(3, 1, 3),
	(4, 2, 2),
	(5, 2, 3),
	(6, 3, 1),
	(7, 3, 3)
)
AS Source (EventServiceId, EventId, ServiceId)
ON Target.EventServiceId = Source.EventServiceId
WHEN NOT MATCHED BY TARGET THEN
INSERT (EventId, ServiceId)
VALUES (EventId, ServiceId);