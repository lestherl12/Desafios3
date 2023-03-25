using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de uso
        int[,] compras = new int[,] {
            { 50, 60, 70, 80, 90 },
            { 150, 250, 350, 450, 550 },
            { 1000, 1100, 1200, 1300, 1400 },
            { 500, 600, 700, 800, 900 },
            { 2000, 2500, 3000, 3500, 4000 }
        };
        int[] descuentos = CalcularDescuentos(compras);
        for (int i = 0; i < descuentos.Length; i++)
        {
            Console.WriteLine("Cliente {0}:", i + 1);
            Console.WriteLine("Compras realizadas:");
            for (int j = 0; j < compras.GetLength(1); j++)
            {
                Console.WriteLine("Compra {0}: {1}", j + 1, compras[i, j]);
            }
            int total = CalcularTotal(compras, i);
            double descuentoPorcentaje = descuentos[i];
            double descuentoValor = total * (descuentoPorcentaje / 100.0);
            double totalConDescuento = total - descuentoValor;
            Console.WriteLine("Total comprado = {0}, Descuento = {1}%", total, descuentoPorcentaje);
            Console.WriteLine("Total con descuento = {0}", totalConDescuento);
            Console.WriteLine();
        }
    }

    static int[] CalcularDescuentos(int[,] compras)
    {
        int[] descuentos = new int[compras.GetLength(0)];
        for (int i = 0; i < compras.GetLength(0); i++)
        {
            int total = CalcularTotal(compras, i);
            if (total >= 100 && total <= 1000)
            {
                descuentos[i] = 10;
            }
            else if (total > 1000)
            {
                descuentos[i] = 20;
            }
        }
        return descuentos;
    }

    static int CalcularTotal(int[,] compras, int cliente)
    {
        int total = 0;
        for (int j = 0; j < compras.GetLength(1); j++)
        {
            total += compras[cliente, j];
        }
        return total;
    }
}