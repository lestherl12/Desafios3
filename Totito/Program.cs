string[,] totito = new string[3, 3]
{
    {" "," "," "},
    {" "," "," "},
    {" "," "," "}
};

bool jugador1 = true;
bool lleno = false;

while (true)
{
    Console.Clear();
    Console.WriteLine("Jugador 1: X");
    Console.WriteLine("Jugador 2: O");
    Console.WriteLine();

    // Imprimir la matriz
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(totito[i, j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine("- - -");
    }

    int fila = -1;
    int columna = -1;

    if (jugador1)
    {
        Console.WriteLine("Jugador 1, ingrese las coordenadas de su jugada (fila,columna):");
    }
    else
    {
        Console.WriteLine("Jugador 2, ingrese las coordenadas de su jugada (fila,columna):");
    }

    try
    {
        string[] coordenadas = Console.ReadLine().Split(',');
        fila = int.Parse(coordenadas[0]) - 1;
        columna = int.Parse(coordenadas[1]) - 1;
    }
    catch
    {
        Console.WriteLine("Coordenadas inválidas, inténtelo de nuevo");
        Console.ReadLine();
        continue;
    }

    if (fila < 0 || fila > 2 || columna < 0 || columna > 2)
    {
        Console.WriteLine("Coordenadas inválidas, inténtelo de nuevo");
        Console.ReadLine();
        continue;
    }

    if (totito[fila, columna] != " ")
    {
        Console.WriteLine("Esta casilla ya está ocupada, inténtelo de nuevo");
        Console.ReadLine();
        continue;
    }

    if (jugador1)
    {
        totito[fila, columna] = "X";
    }
    else
    {
        totito[fila, columna] = "O";
    }

    jugador1 = !jugador1;

    // Revisar si se han llenado todos los espacios
    lleno = true;
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (totito[i, j] == " ")
            {
                lleno = false;
            }
        }
    }

    if (lleno)
    {
        Console.WriteLine("¡Todos los espacios han sido llenados! Revise quién ganó.");
        Console.ReadLine();
        break;
    }
}
