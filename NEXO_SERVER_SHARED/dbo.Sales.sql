CREATE TABLE [dbo].[Sales] (
    [IP]                NVARCHAR (255) NOT NULL,
    [SaleID]            NVARCHAR (255) NOT NULL,
    [CertificationCode] NVARCHAR (255) NOT NULL,
    [Accepted]          BIT            NOT NULL,
    CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED ([IP] ASC, [SaleID] ASC, [CertificationCode] ASC)
);

