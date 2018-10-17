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

            //Console.WriteLine(alura);
            //Console.WriteLine(caelum);
            //Console.WriteLine(casaDoCodigo);

            //MATRIZ = ARRAY

            //Forma de inicialização com tamanho
            //string[] empresas = new string[3];
            //empresas[0] = alura;
            //empresas[1] = caelum;
            //empresas[2] = casaDoCodigo;

            //Forma de inicialização com tamanho automático
            //string[] empresas = new string[]
            //{
            //    alura, caelum, casaDoCodigo
            //};

            //Forma de inicialização simplificada
            string[] empresas = { alura, caelum, casaDoCodigo };

            //Imprime cada um dos elementos
            Imprimir(empresas);

            //alterar a variável não afeta o valor do elemento do array!
            caelum = "Caelum Ensino e Inovação";

            Imprimir(empresas);

            //mudando valor de um elemento do array
            empresas[1] = "Caelum Ensino e Inovação";

            Imprimir(empresas);

            Console.WriteLine("Primeiro elemento: " + empresas[0]);
            Console.WriteLine("Último elemento: " + empresas[empresas.Length - 1]);


        }

        private static void Imprimir(string[] empresas)
        {
            for (int i = 0; i < empresas.Length; i++)
            {
                string empresa = empresas[i];
                Console.WriteLine(empresa);
            }
        }
    }
    ///< image url="$(ProjectDir)\img6.png"/>
}

