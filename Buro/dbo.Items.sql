CREATE TABLE [dbo].[Items] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Color]       NVARCHAR (50) NOT NULL,
    [Weight]      REAL          NOT NULL,
    [SearchTime]  NVARCHAR (50) NOT NULL,
    [SearchPlace] NVARCHAR (50) NOT NULL,
    [FilePath]    NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

