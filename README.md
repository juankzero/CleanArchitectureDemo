
# CleanArchitectureDemo

This project is a RESTful API built with .NET 8 demonstrating CRUD operations using Clean Architecture. The main entity is **Course**, representing a course management system.

## Project Structure

- **Domain**: Contains the `Course` entity and `ICourseRepository` interface.
- **Application**: Contains DTOs, Commands, Queries, and Handlers.
- **Infrastructure**: Implements repository and database context.
- **WebAPI**: Exposes HTTP endpoints via `CoursesController`.

## How to Run

1. Open `CleanArchitectureDemo.sln` in Visual Studio.
2. Configure the database connection in `AppDbContext`.
3. Run the WebAPI project.

## Endpoints

- `GET /api/courses` - Retrieve all courses.
- `GET /api/courses/{id}` - Retrieve a course by ID.
- `POST /api/courses` - Create a new course.
- `PUT /api/courses/{id}` - Update an existing course.
- `DELETE /api/courses/{id}` - Delete a course.

## Requirements

- .NET 8 SDK
- Visual Studio 2022 or later

## Author
Generated as part of the diploma program "Modernization of Software Architecture and Cloud".
