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

            Console.WriteLine(alura);
            Console.WriteLine(caelum);
            Console.WriteLine(casaDoCodigo);

            //string[] empresas = new string[3];
            //empresas[0] = alura;
            //empresas[1] = caelum;
            //empresas[2] = casaDoCodigo;

            //string[] empresas = new string[]
            //{
            //    alura, caelum, casaDoCodigo
            //};

            //string[] empresas = { alura, caelum, casaDoCodigo };

            var empresas = new string[] { alura, caelum, casaDoCodigo };

            for (int i = 0; i < empresas.Length; i++)
            {
                Console.WriteLine(empresas[i]);
            }

            foreach (var empresa in empresas)
            {
                Console.WriteLine(empresa);
            }
        }
    }
}
