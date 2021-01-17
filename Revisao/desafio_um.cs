using System;

namespace desafioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Informação já revelado no exercicio
            int consumoCarro = 12;

            // Recebendo o primeiro dado 'tempo gasto na viagem em horas'
            Console.WriteLine("Digite o tempo gasto na viagem em HORAS: ");
            // Convertendo de string para int
            int tempoViagem = Convert.ToInt32(Console.ReadLine());

            // Recebendo o primeiro dado 'velocidade média da viagem em KM/h'
            Console.WriteLine("Digite a velocidade média durante a viagem em KM/h: ");
            // Convertendo de string para int
            int velocidadeMedia = Convert.ToInt32(Console.ReadLine());

            // Chamando método para realizar calculo e exibir resultado
            CalculaGasto(tempoViagem, velocidadeMedia, consumoCarro);
        }

        private static void CalculaGasto(int tempoViagem, int velocidadeMedia, int consumoCarro)
        {
            int teste = tempoViagem * velocidadeMedia;
            decimal resultado = teste / (decimal)consumoCarro;
            decimal testeDois = Math.Round(resultado, 3);
            Console.WriteLine(testeDois.ToString());
        }
    }
}