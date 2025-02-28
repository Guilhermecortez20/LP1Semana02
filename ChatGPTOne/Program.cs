using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclo de interação com o usuário
            while (true)
            {
                // Solicita uma questão ao utilizador
                Console.WriteLine("Por favor, insira uma questão (ou 'EXIT' para sair):");
                string questao = Console.ReadLine().Trim().ToLower();

                // Se o utilizador digitar 'EXIT', o ciclo termina
                if (questao == "exit")
                {
                    Console.WriteLine("Até logo!");
                    break;
                }

                // Resposta para questões reconhecidas
                switch (questao)
                {
                    case "qual é o seu nome?":
                        Console.WriteLine("Eu sou o ChatGPTOne!");
                        break;
                    case "como você está?":
                        Console.WriteLine("Eu estou bem, obrigado por perguntar!");
                        break;
                    case "qual é a capital de portugal?":
                        Console.WriteLine("A capital de Portugal é Lisboa.");
                        break;
                    case "quem é o presidente de portugal?":
                        Console.WriteLine("O presidente de Portugal é Marcelo Rebelo de Sousa.");
                        break;
                    default:
                        // Se a questão não for reconhecida
                        Console.WriteLine("Desculpe, não entendi a sua questão.");
                        break;
                }
            }
        }
    }
}

