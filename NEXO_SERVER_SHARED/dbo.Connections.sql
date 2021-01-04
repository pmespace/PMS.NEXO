CREATE TABLE [dbo].[Connections] (
    [IP]                  NVARCHAR (255) NOT NULL,
    [SaleID]              NVARCHAR (255) NULL,
    [POIID]               NVARCHAR (255) NULL,
    [LoginTimestamp]      NVARCHAR (255) NOT NULL,
    [LogoutTimestamp]     NVARCHAR (255) NULL,
    [Logged]              BIT            NOT NULL,
    [ManufacturerID]      NVARCHAR (255) NULL,
    [ApplicationName]     NVARCHAR (255) NULL,
    [SoftwareVersion]     NVARCHAR (255) NULL,
    [CertificationCode]   NVARCHAR (255) NULL,
    [AutoLogoutTimestamp] NVARCHAR (255) NULL,
    CONSTRAINT [PK_Connections] PRIMARY KEY CLUSTERED ([IP] ASC, [LoginTimestamp] ASC, [Logged] ASC)
);

