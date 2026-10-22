# Sistema de Gestión de Productos TechStore UISIL

**Tarea programada Programación II*
Universidad Internacional San Isidro Labrador
Facultad de Ingeniería de Sistemas

**Estudiante:** Grace Romero Sanabria

## Descripción del sistema

Aplicación de escritorio para administrar los productos de una pequeña tienda de tecnología. Permite gestionar categorías y productos, 
y cada producto pertenece a una categoría. Los datos se guardan en una base de datos SQL Server.

## Funcionalidades principales

- Inicio de sesión con límite de 3 intentos.
- Pantalla principal con el total de productos y los productos con stock bajo (5 unidades o menos).
- Categorías: registrar, consultar, modificar y eliminar, con confirmación antes de eliminar. 
- No se permite eliminar una categoría que tenga productos asociados.
- Productos: registrar, consultar, modificar y eliminar, con confirmación antes de eliminar.
- Búsqueda de productos por nombre.
- Selección obligatoria de categoría al registrar o modificar un producto.
- Fecha de registro asignada automáticamente.
- Valor del inventario (precio × stock) calculado por la aplicación, sin almacenarse en la base de datos.
- Validación de datos con mensajes visuales (ErrorProvider) y cuadros de diálogo (MessageBox).

## Tecnologías utilizadas

- C# con Windows Forms (10.NET versión)
- Microsoft SQL Server (2022, instancia SQLEXPRESS) y SQL Server Management Studio (SSMS)
- Visual Studio [2022]
- Paquetes NuGet: Microsoft.Data.SqlClient y Guna.UI2.WinForms.
- Git y GitHub

## Estructura del proyecto

```
TechStore/
├── Entidades/        Clases Categoria y Producto
├── Datos/            Conexión y consultas a SQL Server
├── Logica/           Validaciones y reglas del sistema
├── Presentacion/     Formularios (login, principal, categorías, productos)
├── Program.cs        Punto de entrada
└── TechStoreDB.sql   Script de la base de datos
```

El proyecto está organizado en capas: la interfaz solo muestra y recibe datos, la lógica valida y aplica las reglas, 
y la capa de datos es la única que habla con SQL Server.

## Requisitos para ejecutar

1. Windows con Visual Studio 2022 y la carga de trabajo de desarrollo de escritorio con .NET.
2. SQL Server Express instalado como instancia `SQLEXPRESS`.
3. SQL Server Management Studio (SSMS).
4. Conexión a internet la primera vez, para que Visual Studio restaure los paquetes NuGet.

## Creación de la base de datos

1. Abrir SSMS y conectarse a `.\SQLEXPRESS`.
2. Abrir el archivo `TechStoreDB.sql`.
3. Ejecutarlo completo (F5). Crea la base `TechStoreDB`, las tablas `Categorias` y `Productos` y los datos de prueba.

## Conexión a SQL Server

La cadena de conexión está en `Datos/ConexionSql.cs`:

```
Server=.\SQLEXPRESS;Database=TechStoreDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;
```

## Ejecución del sistema

1. Abrir `TechStore.slnx` en Visual Studio.
2. Esperar a que se restauren los paquetes NuGet.
3. Presionar F5.
4. Iniciar sesión con el usuario de demostración: `uisil` / `1234`.

## Uso de inteligencia artificial

Claude (Anthropic) para explicar los conceptos, revisar el código contra la rúbrica, entender errores de compilación.

Corrección de la precisión decimal del precio, separación de validaciones entre capas, encapsulamiento de las entidades, revisión y mojara de este README.

Todo el código entregado fue revisado y comprendido por mi.