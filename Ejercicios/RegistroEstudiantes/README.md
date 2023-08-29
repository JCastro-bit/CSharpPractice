# Registro de Estudiantes en C#

## Descripción

Este ejercicio se centra en la creación y manipulación de clases y objetos en C#. Deberás crear un pequeño sistema de registro para estudiantes con funcionalidades básicas como añadir estudiantes, listar estudiantes y calcular el promedio de sus calificaciones.

## Objetivos

- Entender el uso de clases y objetos.
- Practicar la manipulación de listas.
- Mejorar tus habilidades en programación orientada a objetos.

### Instrucciones:

1. Crea una clase `Estudiante` con los siguientes campos:
    - `nombre` (string)
    - `apellido` (string)
    - `edad` (int)
    - `calificacion` (double)
2. Añade un constructor a la clase `Estudiante` que acepte todos los campos.
3. Crea una clase `RegistroEstudiantes` con un campo que sea una lista de `Estudiante`.
4. Añade los siguientes métodos a la clase `RegistroEstudiantes`:
    - `AgregarEstudiante(Estudiante e)`: Añade un estudiante a la lista.
    - `ListarEstudiantes()`: Muestra todos los estudiantes en la lista.
    - `PromedioCalificaciones()`: Calcula y devuelve el promedio de calificaciones de todos los estudiantes.
5. En la clase `Program`, implementa el código necesario para agregar algunos estudiantes al registro y luego mostrar la lista y el promedio de calificaciones.

### Código de inicio

Aquí hay un esqueleto de código para empezar:

```csharp
using System;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    public Estudiante(string nombre, string apellido, int edad, double calificacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Calificacion = calificacion;
    }
}

class RegistroEstudiantes
{
    private List<Estudiante> estudiantes;

    public RegistroEstudiantes()
    {
        estudiantes = new List<Estudiante>();
    }

    public void AgregarEstudiante(Estudiante e)
    {
        // Implementa este método
    }

    public void ListarEstudiantes()
    {
        // Implementa este método
    }

    public double PromedioCalificaciones()
    {
        // Implementa este método
        return 0.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Implementa el código aquí
    }
}

```

### Tarea:

Tu tarea es completar los métodos `AgregarEstudiante`, `ListarEstudiantes`, y `PromedioCalificaciones` en la clase `RegistroEstudiantes`, y luego usar estos métodos en la clase `Program` para demostrar cómo funcionan.

Espero que encuentres este ejercicio interesante y útil para practicar tus habilidades en C#.

## Recursos

- [Documentación de C#](https://docs.microsoft.com/en-us/dotnet/csharp/)