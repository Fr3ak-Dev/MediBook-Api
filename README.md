# 🏥 MediBook - Backend API

API RESTful para sistema de gestión de citas médicas. Desarrollado con .NET Core 8 y Entity Framework Core.

## 🔗 Proyecto Completo

Este es el **backend** del sistema MediBook. Para ver el proyecto completo:
- **Frontend (React)**: https://github.com/Fr3ak-Dev/MediBook-Api

## 🚀 Características

- ✅ API RESTful con ASP.NET Core 8
- ✅ Entity Framework Core con SQL Server
- ✅ CRUD completo para:
  - Pacientes
  - Médicos
  - Especialidades
  - Citas
- ✅ Relaciones entre entidades
- ✅ Migraciones automáticas
- ✅ CORS configurado para frontend

## 🛠️ Tecnologías

- **.NET 8.0**
- **ASP.NET Core Web API**
- **Entity Framework Core 8**
- **SQL Server Express**
- **C#**

## 📋 Requisitos Previos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- [SQL Server Express 2022+](https://www.microsoft.com/sql-server/sql-server-downloads)

## 🔧 Instalación y Ejecución

### 1. Clonar el repositorio
```bash
git clone https://github.com/Fr3ak-Dev/MediBook-Api
cd MediBookAPI
```

### 2. Restaurar paquetes
```bash
dotnet restore
```

### 3. Configurar la base de datos

El connection string está en `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=MediBookDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

### 4. Ejecutar migraciones
```bash
dotnet ef database update
```

### 5. Ejecutar la aplicación
```bash
dotnet run
```

La API estará disponible en `http://localhost:5154`

## 📡 Endpoints Principales

### Pacientes
- `GET /api/Pacientes` - Listar todos
- `GET /api/Pacientes/{id}` - Obtener por ID
- `POST /api/Pacientes` - Crear
- `PUT /api/Pacientes/{id}` - Actualizar
- `DELETE /api/Pacientes/{id}` - Eliminar

### Médicos
- `GET /api/Medicos` - Listar todos
- `GET /api/Medicos/{id}` - Obtener por ID
- `POST /api/Medicos` - Crear
- `PUT /api/Medicos/{id}` - Actualizar
- `DELETE /api/Medicos/{id}` - Eliminar

### Especialidades
- `GET /api/Especialidades` - Listar todos
- `GET /api/Especialidades/{id}` - Obtener por ID
- `POST /api/Especialidades` - Crear
- `PUT /api/Especialidades/{id}` - Actualizar
- `DELETE /api/Especialidades/{id}` - Eliminar

### Citas
- `GET /api/Citas` - Listar todos
- `GET /api/Citas/{id}` - Obtener por ID
- `POST /api/Citas` - Crear
- `PUT /api/Citas/{id}` - Actualizar
- `DELETE /api/Citas/{id}` - Eliminar

## 📁 Estructura del Proyecto
```
MediBookAPI/
├── Controllers/         # Controladores de API
├── Models/             # Modelos de datos
│   ├── Paciente.cs
│   ├── Medico.cs
│   ├── Especialidad.cs
│   └── Cita.cs
├── Data/               # DbContext
│   └── AppDbContext.cs
├── Migrations/         # Migraciones de EF Core
├── Program.cs          # Configuración de la aplicación
└── appsettings.json    # Configuración
```

## 🗄️ Modelo de Datos

### Paciente
- Id, Nombre, Apellido, Cedula, FechaNacimiento, Telefono, Email, Direccion, NumeroHistoriaClinica

### Medico
- Id, Nombre, Apellido, Cedula, Telefono, Email, EspecialidadId

### Especialidad
- Id, Nombre, Descripcion

### Cita
- Id, PacienteId, MedicoId, FechaHora, Motivo, Estado, Observaciones