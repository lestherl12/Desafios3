using System;

class Program
{
    static void Main(string[] args)
    {
        string[] tareas = new string[10];
        int contador = 0;
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("------- Lista de Tareas --------\n");
            Console.WriteLine("1. Agregar tarea");
            Console.WriteLine("2. Eliminar tarea");
            Console.WriteLine("3. Mostrar tareas");
            Console.WriteLine("4. Salir");

            Console.Write("\nSeleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (contador < tareas.Length)
                    {
                        Console.Write("\nIngrese la tarea: ");
                        tareas[contador] = Console.ReadLine();
                        contador++;
                        Console.WriteLine("\nTarea agregada correctamente.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nLa lista de tareas está llena.");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    if (contador > 0)
                    {
                        Console.Write("\nIngrese el número de tarea a eliminar: ");
                        int tareaEliminar = int.Parse(Console.ReadLine());
                        if (tareaEliminar > 0 && tareaEliminar <= contador)
                        {
                            for (int i = tareaEliminar - 1; i < contador - 1; i++)
                            {
                                tareas[i] = tareas[i + 1];
                            }
                            contador--;
                            Console.WriteLine("\nTarea eliminada correctamente.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nNúmero de tarea inválido.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo hay tareas para eliminar.");
                        Console.ReadKey();
                    }
                    break;

                case 3:
                    if (contador > 0)
                    {
                        Console.WriteLine("\n------- Lista de Tareas --------\n");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tareas[i]}");
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nNo hay tareas para mostrar.");
                        Console.ReadKey();
                    }
                    break;

                case 4:
                    Console.WriteLine("\nGracias por utilizar la aplicación.");
                    break;

                default:
                    Console.WriteLine("\nOpción inválida.");
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 4);
    }
}
