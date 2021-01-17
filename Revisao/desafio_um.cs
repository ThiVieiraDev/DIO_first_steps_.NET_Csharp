using System;

namespace desafioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            float consumoCarro = 12;
            float tempoViagem = 0;
            float velocidadeMedia = 0;

            float resultado = 0;

            Console.WriteLine("Digite o tempo gasto na viagem em HORAS: ");
            string tempoViagemSTRING = Console.ReadLine();
            Console.WriteLine("Digite a velocidade média durante a viagem em KM/h: ");
            string velocidadeMediaSTRING = Console.ReadLine();
            
            Console.WriteLine($"Tempo da Viagem em horas: {tempoViagemSTRING} Velocidade Média em KM/h: {velocidadeMediaSTRING}");

            tempoViagem = float.Parse(tempoViagemSTRING);
            velocidadeMedia = float.Parse(velocidadeMediaSTRING);

            resultado = (tempoViagem * velocidadeMedia) / consumoCarro;
            Console.WriteLine($"Tempo x VelocidadeM. {resultado}");

            // resultado = (tempoViagemSTRING * velocidadeMediaSTRING)

        }
    }
}