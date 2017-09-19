CREATE PROCEDURE [dbo].[Procedure]
	@MyId int
AS
	SELECT * 
	from dbo.myTable
	where Myid=@MyId
RETURN 0
