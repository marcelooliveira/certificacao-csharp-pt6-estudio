using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";

            ////inicializando uma lista populada
            //List<string> empresas = new List<string>
            //{
            //    alura,
            //    caelum,
            //    casaDoCodigo
            //};

            //declarando uma lista vazia
            List<string> empresas = new List<string>();
            //alimentando a lista com método Add
            empresas.Add(alura);
            empresas.Add(caelum);
            empresas.Add(casaDoCodigo);

            Imprimir(empresas);

            //Pegando o primeiro elemento (usando índice)
            Console.WriteLine("A primeira empresa é " + empresas[0]);
            //Pegando o primeiro elemento (usando LINQ)
            Console.WriteLine("A primeira empresa é " + empresas.First());

            //Pegando o último elemento (usando índice)
            Console.WriteLine("A última empresa é " + empresas[empresas.Count - 1]);
            //Pegando o último elemento (usando LINQ)
            Console.WriteLine("A última empresa é " + empresas.Last());

            //modificando elemento pelo índice
            empresas[0] = "Trabalhando com Listas";
            Imprimir(empresas);

            //Obtendo primeiro elemento que atende uma condição
            //(usando LINQ e expressão lambda no predicate)
            Console.WriteLine("A primeira empresa 'Trabalhando' é: "
                + empresas.First(empresa => empresa.Contains("Trabalhando")));

            //Obtendo último elemento que atende uma condição
            //(usando LINQ e expressão lambda no predicate)
            Console.WriteLine("A última empresa 'Trabalhando' é: "
                + empresas.Last(empresa => empresa.Contains("Trabalhando")));

            ////Obtendo primeiro elemento que atende uma condição,
            ////mas nenhum elemento atende, logo obtemos uma exceção!
            //Console.WriteLine("A primeira empresa 'Conclusão' é: "
            //    + empresas.First(empresa => empresa.Contains("Conclusão")));

            Console.WriteLine();

            //Obtendo o primeiro elemento que atende uma condição OU
            //um valor default (null) se não houver nenhum
            //(de forma segura e sem gerar exceção)
            Console.WriteLine("A primeira empresa 'Conclusão' é: "
                + empresas.FirstOrDefault(empresa => empresa.Contains("Conclusão")));

            Console.WriteLine();

            //Revertendo a sequência da lista
            empresas.Reverse();
            Imprimir(empresas);

            //Revertendo NOVAMENTE a sequência da lista
            empresas.Reverse();
            Imprimir(empresas);

            //Removendo o último elemento (por índice)
            empresas.RemoveAt(empresas.Count - 1);
            Imprimir(empresas);

            //Adicionando um elemento (ao final da lista)
            empresas.Add("Conclusão");
            Imprimir(empresas);

            //Ordenando a lista pela ordem natural dos elementos (alfabética)
            empresas.Sort();
            Imprimir(empresas);

            //Ordenando a lista através de um comparador custom,
            //por ordem de tamanho da string
            empresas.Sort((empresa1, empresa2) => empresa1.Length.CompareTo(empresa2.Length));
            Imprimir(empresas);

            //Copiando os 2 últimos elementos de uma lista para
            //uma nova lista
            List<string> copia = empresas.GetRange(empresas.Count - 2, 2);
            Imprimir(copia);

            //Clonando a lista de empresas para uma outra lista 
            List<string> clone = new List<string>(empresas);
            Imprimir(clone);

            //Removendo os dois últimos elementos da lista, pelo índice
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> empresas)
        {
            Console.WriteLine();
            ////Enumerando uma lista (laço FOREACH é mais simples)
            //foreach (var empresa in empresas)
            //{
            //    Console.WriteLine(empresa);
            //}

            //Enumerando uma lista (laço FOR permite mais controle!)
            //for (int i = 0; i < empresas.Count; i++)
            //{
            //    Console.WriteLine(empresas[i]);
            //}

            //Método ForEach: 
            //Executa uma ação (Action) para cada elemento do array
            empresas.ForEach(empresa => Console.WriteLine(empresa));
            Console.WriteLine();
        }
    }
}
