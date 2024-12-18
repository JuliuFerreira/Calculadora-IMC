using System;

class Program
{
    static void Main()
    {
        // Define um array de inteiros chamado idades contendo os números 12, 20 e 30.
        var idades = new int[] { 12, 20, 30 };

        // Variável para armazenar a soma
        int resultado = 0;

        // Loop para somar todas as idades, foreach: É mais simples e direto para iterar sobre todos os elementos de uma coleção sem precisar gerenciar índices.
        foreach (var idade in idades)
        {
            resultado += idade; // Adiciona cada idade à variável resultado
        }

        // Exibe o resultado
        Console.WriteLine($"A soma das idades é: {resultado}");
    }
}
