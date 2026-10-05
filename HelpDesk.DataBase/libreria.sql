USE [master];
GO

-- 1. Validar y recrear la base de datos limpia
IF DB_ID('libreria_db') IS NOT NULL
BEGIN
	ALTER DATABASE libreria_db SET SINGLE_USER WITH ROLLBACK IMMEDIATE
	DROP DATABASE libreria_db
END
GO

CREATE DATABASE libreria_db;
GO

USE libreria_db;
GO


-- 2. Tabla de Roles
CREATE TABLE roles (
    id INT IDENTITY(1,1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    activo BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_roles PRIMARY KEY (id),
    CONSTRAINT UQ_roles_nombre UNIQUE (nombre)
);
GO


-- 3. Tabla de Usuarios
CREATE TABLE usuarios (
    id INT IDENTITY(1,1) NOT NULL,
    correo VARCHAR(150) NOT NULL, 
    contraseña VARBINARY(MAX) NOT NULL, 
    rol_id INT NOT NULL,
    estado BIT NOT NULL DEFAULT 1,
    fecha_registro DATETIME2 NOT NULL DEFAULT GETDATE(),

    CONSTRAINT PK_usuarios PRIMARY KEY (id),
    CONSTRAINT UQ_usuarios_correo UNIQUE (correo),
    CONSTRAINT FK_usuarios_roles FOREIGN KEY (rol_id) REFERENCES roles(id)
);
GO


-- 4. Tabla de Categorías
CREATE TABLE categorias (
    id INT IDENTITY(1,1) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT NULL,
    activo BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_categorias PRIMARY KEY (id),
    CONSTRAINT UQ_categorias_nombre UNIQUE (nombre)
);
GO


-- 5. Tabla de Subcategorías
CREATE TABLE subcategorias (
    id INT IDENTITY(1,1) NOT NULL,
    categoria_id INT NOT NULL,
    nombre VARCHAR(100) NOT NULL, 
    especificaciones TEXT NULL,
    activo BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_subcategorias PRIMARY KEY (id),
    CONSTRAINT FK_subcategorias_categorias FOREIGN KEY (categoria_id) REFERENCES categorias(id) ON DELETE CASCADE
);
GO


-- 6. Tabla de Productos
CREATE TABLE productos (
    id INT IDENTITY(1,1) NOT NULL,
    codigo_barras VARCHAR(50) NULL,
    nombre VARCHAR(150) NOT NULL,
    subcategoria_id INT NULL, 
    marca VARCHAR(50) NOT NULL,
    precio_costo DECIMAL(10, 2) NOT NULL, 
    precio_venta DECIMAL(10, 2) NOT NULL,
    stock_actual INT NOT NULL DEFAULT 0,
    stock_minimo INT NOT NULL DEFAULT 5,
    activo BIT NOT NULL DEFAULT 1,

    CONSTRAINT PK_productos PRIMARY KEY (id),
    CONSTRAINT UQ_productos_codigo_barras UNIQUE (codigo_barras),
    CONSTRAINT FK_productos_subcategorias FOREIGN KEY (subcategoria_id) REFERENCES subcategorias(id)
);
GO


-- 7. Tabla de Entradas de Inventario
CREATE TABLE entradas (
    id INT IDENTITY(1,1) NOT NULL,
    usuario_id INT NOT NULL, 
    fecha_ingreso DATETIME2 NOT NULL DEFAULT GETDATE(),
    observaciones TEXT NULL,

    CONSTRAINT PK_entradas PRIMARY KEY (id),
    CONSTRAINT FK_entradas_usuarios FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
);
GO


-- 8. Tabla de Detalle de Entradas
CREATE TABLE detalle_entradas (
    id INT IDENTITY(1,1) NOT NULL,
    entrada_id INT NOT NULL,
    producto_id INT NOT NULL,
    cantidad INT NOT NULL,
    precio_costo_unitario DECIMAL(10, 2) NOT NULL,

    CONSTRAINT PK_detalle_entradas PRIMARY KEY (id),
    CONSTRAINT FK_detalle_entradas_entradas FOREIGN KEY (entrada_id) REFERENCES entradas(id) ON DELETE CASCADE,
    CONSTRAINT FK_detalle_entradas_productos FOREIGN KEY (producto_id) REFERENCES productos(id)
);
GO


-- 9. Tabla de Ventas
CREATE TABLE ventas (
    id INT IDENTITY(1,1) NOT NULL,
    usuario_id INT NOT NULL, 
    fecha_venta DATETIME2 NOT NULL DEFAULT GETDATE(),
    total_pagar DECIMAL(10, 2) NOT NULL,

    CONSTRAINT PK_ventas PRIMARY KEY (id),
    CONSTRAINT FK_ventas_usuarios FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
);
GO


-- 10. Tabla de Detalle de Ventas
CREATE TABLE detalle_ventas (
    id INT IDENTITY(1,1) NOT NULL,
    venta_id INT NOT NULL,     
    producto_id INT NOT NULL,  
    cantidad INT NOT NULL,     
    precio_unitario DECIMAL(10, 2) NOT NULL, 
    subtotal DECIMAL(10, 2) NOT NULL,        

    CONSTRAINT PK_detalle_ventas PRIMARY KEY (id),
    CONSTRAINT FK_detalle_ventas_ventas FOREIGN KEY (venta_id) REFERENCES ventas(id) ON DELETE CASCADE,
    CONSTRAINT FK_detalle_ventas_productos FOREIGN KEY (producto_id) REFERENCES productos(id)
);
GO


-- 11. Tabla de Bitácora de Errores (Para los bloques CATCH del profesor)
CREATE TABLE log_errores (
    id INT IDENTITY(1,1) NOT NULL,
    mensaje_error NVARCHAR(MAX) NOT NULL,
    numero_error INT NULL,
    procedimiento NVARCHAR(150) NULL,
    linea_error INT NULL,
    usuario_app NVARCHAR(50) NOT NULL,
    fecha_error DATETIME2 NOT NULL DEFAULT GETDATE(),

    CONSTRAINT PK_log_errores PRIMARY KEY (id)
);
GO