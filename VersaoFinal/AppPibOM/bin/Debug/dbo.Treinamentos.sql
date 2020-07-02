CREATE TABLE [dbo].[Treinamentos] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [Titulo]     VARCHAR (50)  NOT NULL,
    [Subtitulo]  VARCHAR (50)  NOT NULL,
    [Autor]      VARCHAR (50)  NOT NULL,
    [DataLimite] DATETIME  NOT NULL,
    [Descricao]  VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Treinamentos] PRIMARY KEY CLUSTERED ([ID] ASC)
);

