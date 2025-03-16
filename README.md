# Catálogo de Producto - Backend

Este es el repositorio del **backend** para la aplicación de catálogo de productos. La solución está desarrollada en **.NET** utilizando **Entity Framework** y **Web API**, con **MySQL** como base de datos.

## 🚀 Tecnologías utilizadas

- .NET
- Entity Framework
- Web API
- MySQL

## 🛠 Instalación y ejecución local

### 1️⃣ Clonar el repositorio
```sh
git clone https://github.com/MemiMint/catalogo-producto-api.git
```

### 2️⃣ Configurar la base de datos
Asegúrate de tener **MySQL** instalado y ejecutándose. Luego, crea una base de datos llamada `catalogo_producto`:
```sql
CREATE DATABASE catalogo_producto;
```
De todas formas hay una carpeta llamada scripts que adentro posee un script llamada create-database.sql
Que te permite crear la base de datos.

### 3️⃣ Configurar la cadena de conexión
Edita el archivo `appsettings.json` y ajusta la cadena de conexión según tu configuración local:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=catalogo_producto;User=root;Password=tu_contraseña;"
}
```

### 4️⃣ Aplicar migraciones
Ejecuta los siguientes comandos en la terminal dentro del directorio del proyecto para aplicar las migraciones de Entity Framework:
```sh
dotnet ef database update
```

### 5️⃣ Ejecutar la API
Inicia la aplicación con:
```sh
dotnet run
```
La API estará disponible en `https://localhost:5026`

## 📌 Endpoints del Controlador de Productos

### 📍 Obtener todos los productos
**GET** `api/products`
- Retorna una lista de todos los productos.

### 📍 Obtener un producto por ID
**GET** `api/product?id={id}`
- Parámetro: `id` (int) - ID del producto a obtener.

### 📍 Buscar productos por nombre
**POST** `api/products/search`
- Body (JSON): `{ "search": "nombre del producto" }`
- Retorna una lista de productos que coincidan con la búsqueda.

### 📍 Crear un nuevo producto
**POST** `api/product`
- Body (FormData):
  ```json
  {
    "file": Blob,
    "nombre": "Producto Ejemplo",
    "descripcion": "Descripción del producto",
    "precio": 100.50,
    "stock": 20,
    "categoriaId": 1
  }
  ```
- Retorna el producto creado.

### 📍 Actualizar un producto
**PUT** `api/product?id={id}`
- Parámetro: `id` (int) - ID del producto a actualizar.
- Body (FormData): Datos actualizados del producto.
- Retorna el producto actualizado.

### 📍 Eliminar un producto
**DELETE** `api/product?id={id}`
- Parámetro: `id` (int) - ID del producto a eliminar.
- Retorna el producto eliminado.
