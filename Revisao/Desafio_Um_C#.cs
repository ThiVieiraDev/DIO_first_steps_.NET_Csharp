// using System;
// class Program
//     {
//         static void Main(string[] args)
//         {
//             // Variável com dado já informado
//             int consumoCarro = 12;
            
//             // Recebendo os dados
//             var dados = Console.ReadLine().Split(" ");

//             // Convertendo de string para int
//             int tempoViagem = int.Parse(dados[0]);
//             int velocidadeMedia = int.Parse(dados[1]);

//             // Chamando método para realizar calculo e exibir resultado
//             CalculaGasto(tempoViagem, velocidadeMedia, consumoCarro);
//         }

//         private static void CalculaGasto(int tempoViagem, int velocidadeMedia, int consumoCarro)
//         {
//             int multiplica = tempoViagem * velocidadeMedia;
//             decimal resultado = multiplica / (decimal)consumoCarro;
//             decimal resultadoFinal = Math.Round(resultado, 3);
//             Console.WriteLine(resultadoFinal.ToString());
//         }
//     }