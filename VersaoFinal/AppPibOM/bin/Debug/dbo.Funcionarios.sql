CREATE TABLE [dbo].[Funcionarios] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [Nome]         VARCHAR (50)  NOT NULL,
    [Funcao]       VARCHAR (50)  NOT NULL,
    [RG]           VARCHAR (50)  NOT NULL,
    [CPF]          VARCHAR (50)  NOT NULL,
    [DataContrato] DATETIME      NOT NULL,
    [Telefone]     VARCHAR (50)  NOT NULL,
    [Endereco]     VARCHAR (MAX) NOT NULL,
    [CEP]          VARCHAR (50)  NOT NULL
);

