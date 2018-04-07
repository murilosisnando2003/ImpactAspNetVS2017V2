CREATE PROCEDURE [dbo].[TarefaSelecionar]
	@id int = null
	
AS
BEGIN
	
	SELECT [Id]
      ,[Nome]
      ,[Concluida]
      ,[Observacao]
      ,[Prioridade]
  FROM [dbo].[Tarefa]
 WHERE id = ISNULL(@id,Id)
 ORDER BY [Concluida],[Prioridade]

END
