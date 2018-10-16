using System;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";

            //MATRIZ = ARRAY 

            string[] empresas = new string[3];
            empresas[0] = alura;
            empresas[1] = caelum;
            empresas[2] = casaDoCodigo;

            //Console.WriteLine(alura);
            //Console.WriteLine(caelum);
            //Console.WriteLine(casaDoCodigo);

            for (int i = 0; i < empresas.Length; i++)
            {
                Console.WriteLine(empresas[i]);
            }

            //primeiro elemento:
            Console.WriteLine("O primeiro elemento é:" + empresas[0]);
            //último elemento:
            Console.WriteLine("O último elemento é:" + empresas[empresas.Length - 1]);
                                                               
            ///<image url="$(ProjectDir)\img6.png"/>
        }
    }
}

