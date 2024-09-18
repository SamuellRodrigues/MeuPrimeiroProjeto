# MeuPrimeiroProjeto
O que é?
Pedra, Papel e Tesoura é um jogo simples de mão jogado entre duas pessoas (ou um jogador e um computador). Cada jogador escolhe uma das três opções:

Pedra: um punho fechado.
Papel: uma mão aberta.
Tesoura: uma mão em forma de "V".
As regras são simples:

Pedra vence Tesoura (porque a pedra quebra a tesoura).
Tesoura vence Papel (porque a tesoura corta o papel).
Papel vence Pedra (porque o papel cobre a pedra).
Se ambos escolherem a mesma opção, é um empate.

Como funciona?
Escolha do Jogador: O jogador escolhe uma das opções (Pedra, Papel ou Tesoura).
Escolha do Computador: O computador escolhe aleatoriamente uma das opções.
Comparação: As escolhas são comparadas para determinar o vencedor.
Resultado: O jogo informa se o jogador venceu, perdeu ou empatou.
Repetição: O jogador pode escolher novamente ou encerrar o jogo.
Como construir o jogo?
Aqui estão os passos para construir o jogo em C#:

Configurar o Ambiente:

Use um ambiente de desenvolvimento como Visual Studio ou Visual Studio Code.
Criar um Novo Projeto:

Crie um projeto de console em C#.
Adicionar Código:

Use o código que você já tem como base. Aqui está um resumo do que o código faz:
using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string[] options = { "Pedra", "Papel", "Tesoura" };

        Console.WriteLine("Escolha: Pedra, Papel ou Tesoura (ou 'sair' para encerrar):");

        while (true)
        {
            string userChoice = Console.ReadLine().Trim();

            if (userChoice.ToLower() == "sair")
                break;

            if (Array.IndexOf(options, userChoice) == -1)
            {
                Console.WriteLine("Escolha inválida! Tente novamente: Pedra, Papel ou Tesoura.");
                continue;
            }

            string computerChoice = options[random.Next(options.Length)];
            Console.WriteLine($"Computador escolheu: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("Empate!");
            }
            else if ((userChoice == "Pedra" && computerChoice == "Tesoura") ||
                     (userChoice == "Tesoura" && computerChoice == "Papel") ||
                     (userChoice == "Papel" && computerChoice == "Pedra"))
            {
                Console.WriteLine("Você venceu!");
            }
            else
            {
                Console.WriteLine("Computador venceu!");
            }

            Console.WriteLine("Escolha: Pedra, Papel ou Tesoura (ou 'sair' para encerrar):");
        }
    }
}

<img src="Pedra Papel e tesoura.png" alt="Print jogo funcinando">