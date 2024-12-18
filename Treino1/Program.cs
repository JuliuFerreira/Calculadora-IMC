using System;
using System.Globalization;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Treino1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");

            double numero1 = Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture); //Quando usar pontos, usar double.

            Console.WriteLine("Digite sua altura: ");

            double numero2 = Convert.ToDouble(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);

            double resultado1 = numero2 * numero2;

            double resultado2 = numero1 / resultado1;

            Console.WriteLine("Seu IMC é:" + resultado2);

            if (resultado2 < 18.5) {

                Console.WriteLine("Vocês esta abaixo do peso idela");

            }

            if( resultado2 > 18.5 && resultado2 < 24.9){

                Console.WriteLine("Parabés, seu peso esta dentro do ideal");

            }

            if (resultado2 > 25.0 && resultado2 < 29.9)
            {

                Console.WriteLine("Vocês esta acima do peso");

            }

            if(resultado2 > 30)
            {

                Console.WriteLine("Você esta OBESO");
            }            

        }
    }

}

