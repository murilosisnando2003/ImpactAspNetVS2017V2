CREATE TABLE [dbo].[Tarefa] (
    [Id]         INT             IDENTITY (1, 1) NOT NULL,
    [Nome]       NVARCHAR (200)  NOT NULL,
    [Concluida]  BIT             NOT NULL,
    [Observacao] NVARCHAR (1000) NULL,
    [Prioridade] INT             NULL
);

