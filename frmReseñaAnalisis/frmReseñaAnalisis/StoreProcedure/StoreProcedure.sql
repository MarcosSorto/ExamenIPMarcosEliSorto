USE AdventureWorks2014
GO

CREATE PROCEDURE sp_InsertarResenia(
	@NombreCodigo NVarchar(50)=NULL,
	@Nombre NVarchar(50)=NULL,
	@Correo NVarchar(50)=NULL,
	@Valor SMALLINT = NULL,
	@Comentarios NVarchar(50)=NULL,
	@FechaModifica DATETIME=NULL,
	@FechaCrea DATETIME=NULL
)
AS
BEGIN
	DECLARE @CodigoProducto INT = NULL;
	SET @CodigoProducto =( SELECT ProductID FROM Production.Product WHERE Name = @NombreCodigo);
	INSERT INTO Production.ProductReview(ProductID,ReviewerName,ReviewDate,EmailAddress,Rating,Comments,ModifiedDate) 
	VALUES (  @CodigoProducto,@Nombre,@FechaCrea,@Correo,@Valor,@Comentarios,@FechaModifica)
END


