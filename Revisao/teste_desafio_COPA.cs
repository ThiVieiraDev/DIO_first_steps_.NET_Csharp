using System;

public class Program 
{

  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int a = 0;
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhas];

    for (int i = 0; i < numeroDeFigurinhasCompradas; i++)
    {
      if (numeroDeFigurinhasCompradas == numeroDeFigurinhasCompradas)
      {
        a ++;
        totalDeFigurinhas = numeroDeFigurinhas - a;
      }

      if (numeroDeFigurinhasCompradas > numeroDeFigurinhas)
      {
        if (numeroDeFigurinhasCompradas == numeroDeFigurinhasCompradas)
        {
          a++;

          if (numeroDeFigurinhasCompradas > numeroDeFigurinhas)
          {
            totalDeFigurinhas = 0;
          }
          else
          {
           totalDeFigurinhas = numeroDeFigurinhas - (numeroDeFigurinhasCompradas - a); 
          }

        }
      }

    }

    Console.WriteLine(totalDeFigurinhas);
  }
}