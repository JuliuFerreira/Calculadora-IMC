using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero;

        // Valida a entrada do usuário
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro não negativo:");
        }

        long fatorial = CalcularFatorial(numero);
        Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
    }

    static long CalcularFatorial(int n)
    {
        long resultado = 1;

        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }

        return resultado;
    }
}
