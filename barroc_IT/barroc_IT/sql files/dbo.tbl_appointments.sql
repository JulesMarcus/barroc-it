CREATE TABLE [dbo].[tbl_appointments] (
    [appointment_ID] INT           NOT NULL IDENTITY(0,1),
    [subject]        NVARCHAR (50) NOT NULL,
    [date]           DATE          NOT NULL,
    [location]       NVARCHAR (50) NOT NULL,
    [time]           TIME (7)      NOT NULL,
    PRIMARY KEY CLUSTERED ([appointment_ID] ASC),
    CONSTRAINT [fk_appointment] FOREIGN KEY ([appointment_ID]) REFERENCES [dbo].[tbl_projects] ([project_ID])
);

