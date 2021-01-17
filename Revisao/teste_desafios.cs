using System;
using System.Linq;

public class AlbumCopa
{

    static void Main(string[] args)
    {
        int numeroDeFigurinhas = int.Parse(Console.ReadLine());
        int numeroDeFigurinhasCompradas = int.Parse(Console.ReadLine());
        int[] albumDeFigurinha = new int[numeroDeFigurinhas];
        int totalDeFigurinhas = 0;

        for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
        {
            int Figurinha = int.Parse(Console.ReadLine());
            if (!albumDeFigurinha.Contains(Figurinha))
            {
                albumDeFigurinha[i] = Figurinha;
                numeroDeFigurinhas -= 1;
            }
            if (numeroDeFigurinhas < 0)
            {
                break;
            }
        }
        totalDeFigurinhas = numeroDeFigurinhas;
        Console.WriteLine(totalDeFigurinhas);
    }
}