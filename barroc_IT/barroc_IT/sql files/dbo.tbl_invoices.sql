CREATE TABLE [dbo].[tbl_invoices] (
    [invoice_ID]    INT           NOT NULL IDENTITY(0,1),
    [status]        NVARCHAR (50) NOT NULL,
    [debit_Num]     NVARCHAR (50) NOT NULL,
    [credit_Num]    NVARCHAR (50) NOT NULL,
    [paid]          NVARCHAR (50) NOT NULL,
    [date]          DATE          NOT NULL,
    [invoice_price] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([invoice_ID] ASC),
    CONSTRAINT [FK_invoices] FOREIGN KEY ([invoice_ID]) REFERENCES [dbo].[tbl_projects] ([project_ID])
);

