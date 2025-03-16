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

De todas maneras hay un script en la carpeta scripts llamado create-database.sql que te permite crear dicha base de datos.

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
