using System;

namespace desafioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis utilizadas para entrada de dados
            int consumoCarro = 12;

            // Recebendo o primeiro dado 'tempo gasto na viagem em horas'
            Console.WriteLine("Digite o tempo gasto na viagem e a velocidade média");
            var resposta = Console.ReadLine().Split(" ");

            // Convertendo de string para int
            int tempoViagem = int.Parse(resposta[0]);
            int velocidadeMedia = int.Parse(resposta[1]);

            // Recebendo o primeiro dado 'velocidade média da viagem em KM/h'
            // Console.WriteLine("Digite a velocidade média durante a viagem em KM/h: ");
            // Convertendo de string para int

            // Chamando método para realizar calculo e exibir resultado
            CalculaGasto(tempoViagem, velocidadeMedia, consumoCarro);
        }

        private static void CalculaGasto(int tempoViagem, int velocidadeMedia, int consumoCarro)
        {
            int multiplica = tempoViagem * velocidadeMedia;
            decimal resultado = multiplica / (decimal)consumoCarro;
            decimal resultadoFinal = Math.Round(resultado, 3);
            Console.WriteLine(resultadoFinal.ToString());
        }
    }
}