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
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "sair")
                break;

            
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
