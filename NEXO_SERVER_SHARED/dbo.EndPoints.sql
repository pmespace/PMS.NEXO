CREATE TABLE [dbo].[EndPoints] (
    [IP]       NVARCHAR (255) NOT NULL,
    [Accepted] BIT            NOT NULL,
    CONSTRAINT [PK_EndPoints] PRIMARY KEY CLUSTERED ([IP] ASC)
);

