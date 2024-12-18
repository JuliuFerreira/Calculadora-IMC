using System;

namespace Emprestimos.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");

            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu CPF:");

            double cpf = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu nome:");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu salário");

            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Didite sua cidade");

            string cidade = Console.ReadLine();


            if (salario <= 3000)
            {

                Console.WriteLine(nome + ", Você pode solicitar um empréstimo pessoal e um empréstimo com garantia");

            }

            else if (salario > 2999 && salario < 5000 && idade < 30 && cidade == "Sao Paulo")
            {
                Console.WriteLine(nome + ", Você pode Você pode solicitar um empréstimo pessoal e um empréstimo com garantia");
            }

            else if (salario > 4999 && idade > 18 && idade < 65)
            {
                Console.WriteLine(nome + ", Você se encaixa para um empréstimo consignado");
            }

            else
            {
                Console.WriteLine(nome + ", Você não tem empréstimos pré aprovado!");
            }


        }

    }
}