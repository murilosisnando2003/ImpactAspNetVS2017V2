
CREATE PROCEDURE [dbo].[TarefaDeletar]
	@id int
	
AS
BEGIN
	
DELETE FROM [dbo].[Tarefa]
 WHERE id = @id

END
