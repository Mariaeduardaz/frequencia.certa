using System;

namespace frequencia.certa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strQuantosnumeros = Console.ReadLine();
            int quantidade = Convert.ToInt32(strQuantosnumeros);

            int[] arrayNumeros = new int[quantidade];
            for (int a = 0; a < quantidade; a++)
            {
                Console.WriteLine("Digite um número:");
                string strNumero = Console.ReadLine();
                int numero = Convert.ToInt32(strNumero);
                arrayNumeros[a] = numero;

            }
            Console.ReadLine();
        }
    }
}
