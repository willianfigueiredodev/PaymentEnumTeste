using System;
using System.Diagnostics;
using System.Linq.Expressions;
using Microsoft.VisualBasic;

namespace Program
{
    public enum Accounts
    {
        Física = 1,
        Jurídica = 2
    }

    public static class Program
    {
        public static void Main(String[] args)
        {
            // Aqui eu criei uma variavel pra receber os valores em int.
            int UserType;
            Accounts accountsType;

            Console.WriteLine("Digite o seu tipo de conta");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1 - Pessoa Física");
            Console.WriteLine("2 - Pessoa Jurídica");

            // Um jeito de converter os valores para inteiro, sem que haja uma exception.
            Console.Write("=>: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out UserType) && UserType == 1 || UserType == 2)
                {
                    break;
                }
                else
                {
                    Console.Write("Opção Inválida. Por favor, escolha 1 ou 2: ");
                }
            }

            accountsType = (Accounts)UserType;

            switch (accountsType)
            {
                case Accounts.Física:
                    Console.WriteLine("Pessoa Física: Você pode sacar até 2.000 reais.");
                    break;
                case Accounts.Jurídica:
                    Console.WriteLine("Pessoa Jurídica: Você pode sacar até 10.000 reais.");
                    break;
                default:
                    break;
            }
        }
    }
}