﻿CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL IDENTITY , 
    [Service Name] TEXT NOT NULL, 
    [Description] TEXT NOT NULL, 
    [Phone Number] TEXT NOT NULL, 
    [Address] TEXT NOT NULL, 
    [Longitude] TEXT NOT NULL, 
    [Latitude] TEXT NOT NULL, 
    [Geotag] TEXT NOT NULL, 
    [Email address] TEXT NOT NULL, 
    [Opening hours] TEXT NOT NULL, 
    [Shelter] BIT NULL, 
    [Food] BIT NULL, 
    [Jobs/Employment] BIT NULL, 
    [Family/community] BIT NULL, 
    [Legal/financial] BIT NULL, 
    [Diversity/inclusion] BIT NULL, 
    [Health/wellbeing] BIT NULL, 
    [Belconnen] BIT NULL, 
    [Gungahlin] BIT NULL, 
    [Woden] BIT NULL, 
    [Tuggeranong] BIT NULL, 
    [Civic] BIT NULL, 
    [Disabled access] TEXT NULL, 
    [Who can access this service?] TEXT NULL, 
    [Referral required] TEXT NULL, 
    [Age range] TEXT NULL, 
    [Cost] TEXT NULL, 
    [Languages] TEXT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
)
