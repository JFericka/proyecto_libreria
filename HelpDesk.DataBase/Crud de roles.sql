USE libreria_db;
GO

CREATE OR ALTER PROC sp_LogErrores_Insertar
(
	@mensaje NVARCHAR(MAX),
	@numero INT,
	@procedimiento NVARCHAR(150),
	@usuarioApp NVARCHAR(50),
	@linea INT
)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO log_errores (mensaje_error, numero_error, procedimiento, linea_error, usuario_app)
	VALUES (@mensaje, @numero, @procedimiento, @linea, @usuarioApp);
END
GO

CREATE OR ALTER PROC sp_MostrarRolesActivos
AS
BEGIN
	SET NOCOUNT ON;

	SELECT id AS Id, nombre AS nombreRol
	FROM roles
	WHERE activo = 1
	ORDER BY nombre
END
GO

CREATE OR ALTER PROC sp_MostrarRoles
(
	@buscar NVARCHAR(50) = NULL,
	@pagina INT = 1,
	@tamPagina INT = 10
)
AS
BEGIN
	SET NOCOUNT ON;

	IF @pagina < 1 SET @pagina = 1;
	IF @tamPagina < 1 SET @tamPagina = 10;
	SET @buscar = TRIM(@buscar);

	SELECT id AS Id, nombre AS nombreRol, activo
	FROM roles
	WHERE
		ISNULL(@buscar, '') = ''
		OR nombre LIKE '%' + @buscar + '%'
	ORDER BY nombre
	OFFSET (@pagina - 1) * @tamPagina ROWS
	FETCH NEXT @tamPagina ROWS ONLY;
END
GO

CREATE OR ALTER PROC sp_ContarRoles
(
	@buscar NVARCHAR(50) = NULL
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @buscar = TRIM(@buscar);

	SELECT COUNT(*) AS Total
	FROM roles
	WHERE
		ISNULL(@buscar, '') = ''
		OR nombre LIKE '%' + @buscar + '%'
END
GO

CREATE OR ALTER PROC sp_ObtenerRolPorId
(
	@Id INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT id AS Id, nombre AS nombreRol, activo
	FROM roles
	WHERE id = @Id
END
GO

CREATE OR ALTER PROC sp_AgregarRol
(
	@nombreRol NVARCHAR(50),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @nombreRol = TRIM(@nombreRol);
	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF EXISTS (SELECT 1 FROM roles WHERE nombre = @nombreRol)
				THROW 50001, 'El rol ya existe', 1;

			INSERT INTO roles (nombre)
			VALUES (@nombreRol);

		COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;

		DECLARE
			@msg NVARCHAR(MAX) = ERROR_MESSAGE(),
			@num INT = ERROR_NUMBER(),
			@proc NVARCHAR(150) = ERROR_PROCEDURE(),
			@line INT = ERROR_LINE();

		EXEC sp_LogErrores_Insertar @msg, @num, @proc, @usuarioApp, @line;

		THROW;
	END CATCH
END
GO

CREATE OR ALTER PROC sp_ActualizarRol
(
	@Id INT,
	@nombreRol NVARCHAR(50),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @nombreRol = TRIM(@nombreRol);
	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF NOT EXISTS (SELECT 1 FROM roles WHERE id = @Id)
				THROW 50002, 'El rol no existe', 1;

			IF EXISTS (SELECT 1 FROM roles WHERE nombre = @nombreRol AND id <> @Id)
				THROW 50001, 'El rol ya existe', 1;

			UPDATE roles
			SET nombre = @nombreRol
			WHERE id = @Id;

		COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;

		DECLARE
			@msg NVARCHAR(MAX) = ERROR_MESSAGE(),
			@num INT = ERROR_NUMBER(),
			@proc NVARCHAR(150) = ERROR_PROCEDURE(),
			@line INT = ERROR_LINE();

		EXEC sp_LogErrores_Insertar @msg, @num, @proc, @usuarioApp, @line;

		THROW;
	END CATCH
END
GO

CREATE OR ALTER PROC sp_CambiarEstadoRol
(
	@Id INT,
	@activo BIT,
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @usuarioApp = TRIM(@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF NOT EXISTS (SELECT 1 FROM roles WHERE id = @Id)
				THROW 50002, 'El rol no existe', 1;

			IF (@activo = 0
				AND EXISTS (SELECT 1 FROM usuarios WHERE rol_id = @Id))
				THROW 50003, 'El rol tiene usuarios asignados', 1;

			UPDATE roles
			SET activo = @activo
			WHERE id = @Id;

		COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;

		DECLARE
			@msg NVARCHAR(MAX) = ERROR_MESSAGE(),
			@num INT = ERROR_NUMBER(),
			@proc NVARCHAR(150) = ERROR_PROCEDURE(),
			@line INT = ERROR_LINE();

		EXEC sp_LogErrores_Insertar @msg, @num, @proc, @usuarioApp, @line;

		THROW;
	END CATCH
END
GO