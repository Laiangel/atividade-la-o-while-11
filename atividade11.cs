using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;

        while (true)
        {
            Console.Write("Digite um número entre 1 e 100: ");

            // Tenta converter a entrada para um número inteiro
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Verifica se o número está no intervalo válido
                if (numero >= 1 && numero <= 100)
                {
                    Console.WriteLine($"Você digitou um número válido: {numero}");
                    break; // Encerra o laço
                }
                else
                {
                    Console.WriteLine("O número está fora do intervalo. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }
    }
}
