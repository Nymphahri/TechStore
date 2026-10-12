/* =====================================================================
   Sistema de Gestión de Productos de TechStore
   Script: creación de base de datos, tablas y datos de prueba
   Microsoft SQL Server
   ===================================================================== */

IF DB_ID('TechStoreDB') IS NULL
BEGIN
    CREATE DATABASE TechStoreDB;
END
GO

USE TechStoreDB;
GO

/* Se elimina primero la tabla hija (Productos) y luego la padre (Categorias)*/
IF OBJECT_ID('dbo.Productos', 'U') IS NOT NULL
    DROP TABLE dbo.Productos;
GO

IF OBJECT_ID('dbo.Categorias', 'U') IS NOT NULL
    DROP TABLE dbo.Categorias;
GO

/*---------------------------------------------------------------------
  Tabla de Categorias
  ---------------------------------------------------------------------*/
CREATE TABLE dbo.Categorias
(
    IdCategoria  INT IDENTITY(1,1) NOT NULL,
    Nombre       NVARCHAR(100)     NOT NULL,
    Descripcion  NVARCHAR(250)     NOT NULL,

    CONSTRAINT PK_Categorias        PRIMARY KEY (IdCategoria),
    CONSTRAINT UQ_Categorias_Nombre UNIQUE (Nombre)
);
GO

/*---------------------------------------------------------------------
  Tabla de Productos
  (el valor del inventario no se guarda: se calcula en la aplicación)
  ---------------------------------------------------------------------*/
CREATE TABLE dbo.Productos
(
    IdProducto     INT IDENTITY(1,1) NOT NULL,
    Nombre         NVARCHAR(100)     NOT NULL,
    Precio         DECIMAL(10,2)     NOT NULL,
    Stock          INT               NOT NULL,
    FechaRegistro  DATETIME          NOT NULL,
    IdCategoria    INT               NOT NULL,

    CONSTRAINT PK_Productos PRIMARY KEY (IdProducto),

    CONSTRAINT FK_Productos_Categorias
        FOREIGN KEY (IdCategoria)
        REFERENCES dbo.Categorias (IdCategoria),

    CONSTRAINT CK_Productos_Precio CHECK (Precio > 0),
    CONSTRAINT CK_Productos_Stock  CHECK (Stock >= 0)
);
GO

/*---------------------------------------------------------------------
  Datos de prueba
  ---------------------------------------------------------------------*/
INSERT INTO dbo.Categorias (Nombre, Descripcion)
VALUES
(N'Computación', N'Productos y accesorios informáticos'),
(N'Accesorios',  N'Accesorios tecnológicos'),
(N'Redes',       N'Productos para conexión de redes'),
(N'Impresión',   N'Impresoras y suministros');
GO

INSERT INTO dbo.Productos (Nombre, Precio, Stock, FechaRegistro, IdCategoria)
VALUES
(N'Teclado inalámbrico',       18500.00, 10, GETDATE(), 1),
(N'Teclado mecánico',          27500.00,  8, GETDATE(), 2),
(N'Mouse óptico',               9500.00, 15, GETDATE(), 2),
(N'Memoria USB 32 GB',          6000.00, 35, GETDATE(), 2),
(N'Cable de red',               3200.00, 25, GETDATE(), 3),
(N'Monitor 24 pulgadas',       120000.00, 10, GETDATE(), 1),
(N'Impresora multifuncional', 80000.00,  6, GETDATE(), 4);
GO

/*---------------------------------------------------------------------
  Verificación: el valor del inventario se calcula, no se almacena
  ---------------------------------------------------------------------*/
SELECT  p.IdProducto,
        p.Nombre,
        p.Precio,
        p.Stock,
        p.FechaRegistro,
        c.Nombre          AS Categoria,
        p.Precio * p.Stock AS ValorInventario
FROM    dbo.Productos  AS p
INNER JOIN dbo.Categorias AS c ON c.IdCategoria = p.IdCategoria
ORDER BY p.IdProducto;
GO