USE libreria_db;
GO

-- 1. Crear Administrador Inicial
CREATE OR ALTER PROC sp_CrearAdministradorInicial
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @rol_id INT;
	DECLARE @usuarioApp NVARCHAR(25) = 'SISTEMA';

	BEGIN TRY
		BEGIN TRANSACTION;
			-- Obtener el id del rol "Administrador", si no existe, crearlo
			SELECT @rol_id = id FROM roles WHERE nombre = 'Administrador';

			IF @rol_id IS NULL
			BEGIN
				INSERT INTO roles(nombre)
				VALUES('Administrador');

				SET @rol_id = SCOPE_IDENTITY();
			END

			-- Crear el usuario admin solo si no existe
			IF NOT EXISTS (SELECT 1 FROM usuarios WHERE correo = 'admin@libreria.com')
			BEGIN
				INSERT INTO usuarios(correo, contraseña, rol_id, estado)
				VALUES('admin@libreria.com',
					   HASHBYTES('SHA2_256', N'Admin123+'),
					   @rol_id,
					   1);
			END
		COMMIT TRANSACTION;			
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;

		DECLARE
			@msg NVARCHAR(MAX) = ERROR_MESSAGE(),
			@num INT = ERROR_NUMBER(),
			@proc NVARCHAR(150) = ERROR_PROCEDURE(),
			@line INT = ERROR_LINE();

		-- Nota: Asegúrate de tener tu tabla tblLogErrores si usas bitácora de errores del profesor
		-- EXEC sp_LogErrores_Insertar @msg, @num, @proc, @usuarioApp, @line;

		THROW;
	END CATCH
END
GO


-- 2. Mostrar Usuarios con Paginación y Filtro
CREATE OR ALTER PROC sp_MostrarUsuarios
(
	@buscar NVARCHAR(100) = NULL,
	@pagina INT  = 1,
	@tamPagina INT = 10
)
AS
BEGIN
	SET NOCOUNT ON;
	
	IF @pagina < 1 SET @pagina = 1;
    IF @tamPagina < 1 SET @tamPagina = 10;
	
	SELECT u.id AS idUsuario, 
		   r.id AS idRol,
		   u.correo AS correoElectronico,
		   r.nombre AS nombreRol,
		   u.estado AS activo
	FROM usuarios u
	INNER JOIN roles r ON u.rol_id = r.id
	WHERE u.correo <> 'admin@libreria.com'
		AND (ISNULL(@buscar, '') = ''
			OR u.correo LIKE '%' + @buscar + '%'
			OR r.nombre LIKE '%' + @buscar + '%')
	ORDER BY u.correo
	OFFSET (@pagina - 1) * @tamPagina ROWS
	FETCH NEXT @tamPagina ROWS ONLY;
END
GO


-- 3. Autenticar Usuario (Login)
CREATE OR ALTER PROC sp_AutenticarUsuario
(
	@correo NVARCHAR(150),
	@claveUsuario NVARCHAR(MAX)
)
AS
BEGIN
	SET NOCOUNT ON;

	-- Verificar si el usuario existe
	IF NOT EXISTS (
		SELECT 1
		FROM usuarios
		WHERE correo = @correo
	)
		THROW 51002, 'El usuario no existe', 1;

	-- Verificar si está inactivo
	IF EXISTS (
		SELECT 1
		FROM usuarios
		WHERE correo = @correo
			AND estado = 0
	)
		THROW 51003, 'El usuario está inactivo', 1;

	-- Verificar contraseña
	IF NOT EXISTS (
		SELECT 1
		FROM usuarios
		WHERE correo = @correo
			AND contraseña = HASHBYTES('SHA2_256', @claveUsuario)
	)
		THROW 51004, 'La contraseña es incorrecta', 1;

	-- Si todo esta correcto
	SELECT u.id AS idUsuario,
		   u.correo AS correoElectronico,
		   r.nombre AS nombreRol,
		   u.estado AS activo,
		   r.id AS idRol
	FROM usuarios u
	INNER JOIN roles r ON u.rol_id = r.id
	WHERE u.correo = @correo
		AND u.contraseña = HASHBYTES('SHA2_256', @claveUsuario)
END
GO


-- 4. Obtener Usuario por ID
CREATE OR ALTER PROC sp_ObtenerUsuarioPorId
(
	@Id INT
)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT id AS Id, 
		   correo AS correoElectronico,
		   rol_id AS idRol,
		   estado AS activo
	FROM usuarios
	WHERE id = @Id
END
GO


-- 5. Agregar Usuario
CREATE OR ALTER PROC sp_AgregarUsuario
(
	@correo NVARCHAR(150),
	@rol_id INT,
	@claveUsuario NVARCHAR(250),
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @correo = TRIM(@correo);
	SET @usuarioApp = TRIM (@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION

			IF EXISTS (
				SELECT 1 
				FROM usuarios 
				WHERE correo = @correo
			)
				THROW 51005, 'El correo ya existe', 1;

			IF NOT EXISTS (
				SELECT 1 
				FROM roles 
				WHERE id = @rol_id
				)
				THROW 51006, 'El rol no existe', 1;

			INSERT INTO usuarios(correo, contraseña, rol_id, estado)
			VALUES(@correo,
				   HASHBYTES('SHA2_256', @claveUsuario),
				   @rol_id,
				   1);

			COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END
GO


-- 6. Actualizar Usuario
CREATE OR ALTER PROC sp_ActualizarUsuario
(
	@idUsuario INT,
	@correo NVARCHAR(150),
	@rol_id INT,
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @correo = TRIM(@correo);
	SET @usuarioApp = TRIM (@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION

			IF NOT EXISTS (
				SELECT 1 
				FROM usuarios WHERE id = @idUsuario
			)
				THROW 51002, 'El usuario no existe', 1;

			IF EXISTS (
				SELECT 1 
				FROM usuarios 
				WHERE correo = @correo 
					AND id <> @idUsuario
			)
				THROW 51005, 'El correo ya existe', 1;

			IF NOT EXISTS (
				SELECT 1 
				FROM roles 
				WHERE id = @rol_id
			)
				THROW 51006, 'El rol no existe', 1;

			UPDATE usuarios
			SET correo = @correo,
				rol_id = @rol_id
			WHERE id = @idUsuario;

		COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END
GO


-- 7. Cambiar Estado de Usuario (Activo/Inactivo)
CREATE OR ALTER PROC sp_CambiarEstadoUsuario
(
	@Id INT,
	@estado BIT,
	@usuarioApp NVARCHAR(25)
)
AS
BEGIN
	SET NOCOUNT ON;

	SET @usuarioApp = TRIM (@usuarioApp);

	BEGIN TRY
		BEGIN TRANSACTION;

			IF NOT EXISTS (
				SELECT 1 
				FROM usuarios 
				WHERE id = @Id
			)
				THROW 51002, 'El usuario no existe', 1;

			UPDATE usuarios
			SET estado = @estado
			WHERE id = @Id;

		COMMIT TRANSACTION;
	END TRY

	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END
GO