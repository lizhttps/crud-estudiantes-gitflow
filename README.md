# CRUD Estudiantes - Git Flow

Proyecto CRUD de la Tarea 3 de Programación III (Profesor: Kelyn Tejada).
Sistema de gestión de estudiantes con ASP.NET Core MVC y SQLite.

## Tecnologías
- C# / .NET 10
- ASP.NET Core MVC
- Entity Framework Core + SQLite
- Git y GitHub (Git Flow)

## Cómo ejecutarlo
No necesita instalar ni configurar nada extra:

```bash
git clone https://github.com/lizhttps/crud-estudiantes-gitflow.git
cd crud-estudiantes-gitflow
dotnet run
```

La base de datos SQLite (`estudiantes.db`) se crea sola al iniciar,
con 3 estudiantes de ejemplo ya cargados.

## Funcionalidades
- Listar estudiantes
- Ver detalles
- Crear estudiante
- Editar estudiante
- Eliminar estudiante

## Ramas
`main`, `developer`, `qa` y ramas `feature/` para cada funcionalidad.
