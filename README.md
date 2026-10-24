# TechStoreUISIL Sistema de Gestión de Inventario

Aplicación de escritorio en C# (Windows Forms) con SQL Server para administrar el inventario de una tienda de tecnología: categorías, productos, búsquedas y un panel con el estado general del inventario.

**Autora:** Grace Romero Sanabria
**Curso:** Programación II Universidad Internacional San Isidro Labrador (UISIL)

---

## Qué hace

- **Inicio de sesión** con usuario y contraseña (máximo 3 intentos) y un botón para probar la conexión con SQL Server antes de entrar.
- **Panel principal** con el resumen del inventario: total de productos, cantidad con stock bajo y valor total en colones (₡). Debajo muestra una tabla con los productos de stock bajo, marcados en rojo.
- **Gestión de categorías**: registrar, modificar, eliminar y buscar por nombre.
- **Gestión de productos**: registrar, modificar, eliminar y buscar por nombre. La tabla muestra el valor de inventario de cada producto (precio × stock) y la fecha de registro.
- **Validaciones** en cada campo, con el mensaje de error junto al control afectado.
- **Mensajes claros** ante situaciones frecuentes: nombre de categoría repetido o categoría con productos asociados que no se puede eliminar.
- **Cierre de sesión** con confirmación, que devuelve al login.

## Capturas

[Agregar aquí capturas de: login, panel principal, categorías y productos.]

## Tecnologías

| Componente | Detalle |
|---|---|
| Lenguaje | C# [versión, por ejemplo 12] |
| Plataforma | .NET version .10 Windows Forms |
| Base de datos | SQL Server Express |
| Acceso a datos | ADO.NET con `Microsoft.Data.SqlClient` (consultas parametrizadas) |
| Interfaz | `Guna.UI2.WinForms` (paquete NuGet) |

## Arquitectura

El proyecto está separado en capas para que cada clase tenga una sola responsabilidad:

```
TechStore
├── Entidades      Categoria, Producto (modelos de datos)
├── Datos          ConexionSql, CategoriaDatos, ProductoDatos (consultas SQL)
├── Logica         CategoriaLogica, ProductoLogica (validaciones y reglas)
└── Presentacion   FrmLogin, FrmPrincipal, FrmCategorias, FrmProductos, AyudanteInterfaz
```

Flujo típico: el formulario recibe los datos, la capa de **Lógica** los valida y, solo si son correctos, la capa de **Datos** los guarda en SQL Server. Los formularios nunca escriben SQL directamente.

## Base de datos

Dos tablas relacionadas:

- **Categorias**: `IdCategoria`, `Nombre` (único), `Descripcion`.
- **Productos**: `IdProducto`, `Nombre`, `Precio`, `Stock`, `FechaRegistro`, `IdCategoria` (llave foránea a Categorias).

Restricciones en la base de datos: `Precio > 0`, `Stock >= 0` y nombre de categoría único.

## Cómo ejecutarlo

### Requisitos

- Windows con Visual Studio 2022 o superior (carga de trabajo de escritorio .NET).
- SQL Server Express (o cualquier instancia de SQL Server) y SSMS.

### Pasos

1. **Clonar o descargar** el proyecto y abrir la solución en Visual Studio.
2. **Crear la base de datos:** abrir `TechStoreDB.sql` en SSMS y ejecutarlo.
   > Si el script falla por las rutas de los archivos `.mdf`/`.ldf` o por el nivel de compatibilidad, cambia el `CREATE DATABASE` por una versión simple (`CREATE DATABASE TechStoreDB;`) y ejecuta el resto del script.
3. **Revisar la cadena de conexión** en `Datos/ConexionSql.cs`:
   ```csharp
   Server=.\SQLEXPRESS;Database=TechStoreDB;Integrated Security=True;...
   ```
   Si tu instancia tiene otro nombre, cámbialo aquí.
4. **Restaurar los paquetes NuGet** (Visual Studio lo hace solo) y presionar **F5**.
5. En el login, usar el botón **Probar conexión** para confirmar que todo está bien.
6. La base de datos empieza vacía: **crea primero una categoría** y después podrás registrar productos.

### Credenciales de acceso

| Usuario | Contraseña |
|---|---|
| `uisil` | `1234` |

Son credenciales de demostración definidas en `FrmLogin.cs`.

## Reglas de validación

| Campo | Regla |
|---|---|
| Nombre de categoría | Obligatorio, único y no puede ser solo números |
| Descripción de categoría | Obligatoria |
| Nombre de producto | Obligatorio |
| Precio | Número mayor que 0 y máximo 99 999 999,99 |
| Stock | Entero, no puede ser negativo |
| Categoría del producto | Debe seleccionarse una |

Un producto se considera de **stock bajo** cuando tiene 5 unidades o menos.

## Limitaciones conocidas

- El usuario y la contraseña están escritos en el código; no hay tabla de usuarios.
- La cadena de conexión está definida en el código, no en un archivo de configuración.
- El límite de stock bajo (5) es fijo.

```
  /\_/\
 ( ^.^ )
  )   (
 (__ __)
 ```