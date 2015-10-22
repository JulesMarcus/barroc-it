CREATE TABLE [dbo].[tbl_users] (
    [user_ID]  INT           NOT NULL IDENTITY(0,1),
    [username] NVARCHAR (50) NOT NULL,
    [password] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([user_ID] ASC)
);

