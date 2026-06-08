using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sistema iniciado");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Jogo de adivinhação");
        Console.WriteLine("2 - Calculadora simples");
        Console.WriteLine("3 - Sair");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                GuessGame();
                break;
            case "2":
                Calculator();
                break;
            case "3":
                Console.WriteLine("Encerrando...");
                return;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("Programa finalizado");
    }

    static void GuessGame()
    {
        Random rand = new Random();
        int secret = rand.Next(1, 51);
        int attempt = 0;
        int tries = 0;

        Console.WriteLine("Adivinhe o número entre 1 e 50");

        while (attempt != secret)
        {
            attempt = Convert.ToInt32(Console.ReadLine());
            tries++;

            if (attempt < secret)
                Console.WriteLine("Maior");
            else if (attempt > secret)
                Console.WriteLine("Menor");
        }

        Console.WriteLine("Acertou em " + tries + " tentativas");
    }

    static void Calculator()
    {
        List<double> values = new List<double>();

        Console.WriteLine("Quantos números deseja usar?");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            values.Add(Convert.ToDouble(Console.ReadLine()));
        }

        Console.WriteLine("Escolha operação (+, -, *, /)");
        string op = Console.ReadLine();

        double result = values[0];

        for (int i = 1; i < values.Count; i++)
        {
            switch (op)
            {
                case "+":
                    result += values[i];
                    break;
                case "-":
                    result -= values[i];
                    break;
                case "*":
                    result *= values[i];
                    break;
                case "/":
                    result /= values[i];
                    break;
            }
        }

        Console.WriteLine("Resultado: " + result);
    }
}
