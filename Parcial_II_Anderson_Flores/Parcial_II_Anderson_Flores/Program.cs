using System;

namespace parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            double[] notas = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nombre del alumno {i + 1}: ");
                nombres[i] = Console.ReadLine();

                do
                {
                    Console.Write($"Nota de {nombres[i]}de 0 a 100): ");
                } while (!double.TryParse(Console.ReadLine(), out notas[i]) || notas[i] < 0 || notas[i] > 100);
            }

            int opcion;
            do
            {
                Console.WriteLine("\nMenú:\n1. Mostrar aprobados\n2. Mostrar no aprobados\n3. Promedio\n4. Salir");
                Console.Write("Seleccione (1-4): ");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: MostrarAlumnos(nombres, notas, true); break;
                        case 2: MostrarAlumnos(nombres, notas, false); break;
                        case 3: MostrarPromedio(notas); break;
                        case 4: Console.WriteLine("¡Hasta luego!"); break;
                        default: Console.WriteLine("Opción inválida"); break;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido.");
                }
            } while (opcion != 4);
        }
