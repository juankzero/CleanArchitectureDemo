
# CleanArchitectureDemo

Este proyecto es una API RESTful desarrollada con .NET 8 que ejemplifica operaciones CRUD siguiendo los principios de Clean Architecture. La entidad principal es **Course**, utilizada para representar un sistema de gestión de cursos.

## 🧱 Estructura del Proyecto

El proyecto está dividido en las siguientes capas:

### 1. Domain
- Contiene la entidad `Course`.
- Define la interfaz `ICourseRepository`.

### 2. Application
- Contiene los `DTOs`, `Commands`, `Queries` y `Handlers`.
- Orquesta la lógica de aplicación y casos de uso.

### 3. Infrastructure
- Implementa `ICourseRepository`.
- Define el contexto de base de datos `AppDbContext` usando Entity Framework Core.

### 4. WebAPI (Presentación)
- Expone los endpoints HTTP a través del controlador `CoursesController`.

## 🚀 Cómo ejecutar

1. Abre `CleanArchitectureDemo.sln` en Visual Studio.
2. Configura la cadena de conexión en `AppDbContext`.
3. Ejecuta el proyecto `CleanArchitectureDemo.WebAPI`.

## 📬 Endpoints disponibles

- `GET /api/courses` → Obtiene todos los cursos.
- `GET /api/courses/{id}` → Obtiene un curso por ID.
- `POST /api/courses` → Crea un nuevo curso.
- `PUT /api/courses/{id}` → Actualiza un curso existente.
- `DELETE /api/courses/{id}` → Elimina un curso.

## 🧪 Pruebas
Puedes probar los endpoints utilizando herramientas como:
- Swagger (si está habilitado en el proyecto)
- Postman
- curl

## 📋 Requisitos
- .NET 8 SDK
- Visual Studio 2022 o superior

## 👨‍🎓 Autor
Proyecto generado como parte del diplomado **Modernization of Software Architecture and Cloud**.
