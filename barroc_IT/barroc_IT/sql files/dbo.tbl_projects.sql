CREATE TABLE [dbo].[tbl_projects] (
    [project_ID]           INT           NOT NULL IDENTITY(0,1),
    [app_Name]             NVARCHAR (50) NOT NULL,
    [maintenance_Contract] BIT           NOT NULL,
    [credit_Worthy]        BIT           NOT NULL,
    [bkr]                  BIT           NOT NULL,
    [price]                NVARCHAR (50) NOT NULL,
    [limit]                NVARCHAR (50) NOT NULL,
    [amount_of_Invoices]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([project_ID] ASC),
    CONSTRAINT [fk_tbl_projects] FOREIGN KEY ([project_ID]) REFERENCES [dbo].[tbl_customers] ([customer_ID])
);

