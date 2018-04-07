
CREATE PROCEDURE [dbo].[TarefaAtualizar]
	@id int,
	@nome nvarchar(200),
	@prioridade int,
	@concluida bit,
	@observacao nvarchar(1000)
AS
BEGIN
	
	UPDATE [dbo].[Tarefa]
    SET [Nome] =@nome
      ,[Concluida] = @concluida
      ,[Observacao] = @observacao
      ,[Prioridade] = @prioridade
 WHERE id = @id

END
