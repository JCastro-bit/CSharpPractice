using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Fibonacci();
    }

    public static void Operadora()
    {
        Console.WriteLine("Hello, World!");
        //introcudir un numero
        Console.WriteLine("Introduce un numero");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        //introcudir un numero
        Console.WriteLine("Introduce otro numero");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("La suma de los numeros es: " + Suma(numero1, numero2));
        Console.WriteLine("La resta de los numeros es: " + Resta(numero1, numero2));
        Console.WriteLine("La multiplicacion de los numeros es: " + Multiplicacion(numero1, numero2));
        Console.WriteLine("La division de los numeros es: " + Division(numero1, numero2));

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return a - b;
        }

        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        static int Division(int a, int b)
        {
            return a / b;
        }
    }

    public static void Fuzzy()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + " FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(i + " Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + " Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Fibonacci()
    {
        int a = 0;
        int b = 1;
        int c = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i < 20; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }

    public class ProjectEstudiante
    {
        // Clase Estudiante
        public class Estudiante
        {
            private string Nombre { get; set; }
            private string Apellido { get; set; }
            private int Edad { get; set; }
            private double Calificacion { get; set; }

            // Constructor de la clase 
            public Estudiante(string nombre, string apellido, int edad, double calificacion)
            {
                Nombre = nombre;
                Apellido = apellido;
                Edad = edad;
                Calificacion = calificacion;
            }            

        }

        // Clase de Registro
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

    }


}