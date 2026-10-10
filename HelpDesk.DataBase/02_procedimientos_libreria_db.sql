-- Ejecutar DESPUÉS del script de tablas. NO borra datos.
USE libreria_db;
GO

-- Log de errores (reutilizable por los CATCH)
CREATE OR ALTER PROCEDURE sp_LogError
    @usuario_app NVARCHAR(50) = N'sistema'
AS
BEGIN
    INSERT INTO log_errores (mensaje_error, numero_error, procedimiento, linea_error, usuario_app)
    VALUES (ERROR_MESSAGE(), ERROR_NUMBER(), ERROR_PROCEDURE(), ERROR_LINE(), @usuario_app);
END
GO

-- Crea el rol Administrador y el usuario admin SOLO si no hay usuarios.
-- Usuario: admin@libreria.com   Contraseña inicial: Admin123*  (cámbiala luego)
CREATE OR ALTER PROCEDURE sp_CrearAdministradorInicial
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        IF NOT EXISTS (SELECT 1 FROM roles WHERE nombre = 'Administrador')
            INSERT INTO roles (nombre) VALUES ('Administrador');

        IF NOT EXISTS (SELECT 1 FROM roles WHERE nombre = 'Vendedor')
            INSERT INTO roles (nombre) VALUES ('Vendedor');

        IF NOT EXISTS (SELECT 1 FROM usuarios)
        BEGIN
            DECLARE @rolId INT = (SELECT id FROM roles WHERE nombre = 'Administrador');
            INSERT INTO usuarios (correo, contraseña, rol_id)
            VALUES ('admin@libreria.com', HASHBYTES('SHA2_256', 'Admin123*'), @rolId);
        END
    END TRY
    BEGIN CATCH
        EXEC sp_LogError;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE sp_Usuario_Insertar
    @Correo VARCHAR(150),
    @Contraseña VARBINARY(MAX),
    @RolId INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        INSERT INTO usuarios (correo, contraseña, rol_id)
        VALUES (@Correo, @Contraseña, @RolId);
        SELECT CAST(SCOPE_IDENTITY() AS INT);
    END TRY
    BEGIN CATCH
        EXEC sp_LogError;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE sp_Usuario_Actualizar
    @Id INT,
    @Correo VARCHAR(150),
    @RolId INT,
    @Estado BIT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE usuarios SET correo = @Correo, rol_id = @RolId, estado = @Estado
        WHERE id = @Id;
    END TRY
    BEGIN CATCH
        EXEC sp_LogError;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE sp_Usuario_CambiarEstado
    @Id INT,
    @Estado BIT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        UPDATE usuarios SET estado = @Estado WHERE id = @Id;
    END TRY
    BEGIN CATCH
        EXEC sp_LogError;
        THROW;
    END CATCH
END
GO

CREATE OR ALTER PROCEDURE sp_Usuario_Listar
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.id, u.correo, u.rol_id, r.nombre AS nombre_rol, u.estado, u.fecha_registro
    FROM usuarios u
    INNER JOIN roles r ON r.id = u.rol_id
    ORDER BY u.id;
END
GO

CREATE OR ALTER PROCEDURE sp_Usuario_ObtenerPorId
    @Id INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT u.id, u.correo, u.rol_id, r.nombre AS nombre_rol, u.estado, u.fecha_registro
    FROM usuarios u
    INNER JOIN roles r ON r.id = u.rol_id
    WHERE u.id = @Id;
END
GO
