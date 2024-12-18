class Program
{
    static void Main(string[] args)
    {
        int numero = 6; // Número que o programa "pensa"

        Console.WriteLine("Digite um número de 1 a 10 para tentar adivinhar o número que pensei");

        int numeroDigitado = 0; // Variável para armazenar o número digitado pelo usuário

        while (numeroDigitado != numero) // Continua enquanto o número digitado for diferente do número pensado
        {
            numeroDigitado = Convert.ToInt32(Console.ReadLine()); // Lê o número digitado pelo usuário

            if (numeroDigitado > numero)
            {
                Console.WriteLine("Você errou, o número digitado é maior que o que pensei, tente novamente!");
            }
            else if (numeroDigitado < numero)
            {
                Console.WriteLine("Você errou, o número digitado é menor que o que pensei, tente novamente!");
            }
            else
            {
                Console.WriteLine("Parabéns, você acertou!");
            }
        }
    }
}