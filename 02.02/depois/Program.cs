using System;
using System.Collections.Generic;

namespace _02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as variáveis iniciais
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";

            //PROBLEMA: começar com um array vazio
            //SOLUÇÃO: trocar um array por uma lista
            List<string> empresas = new List<string>();

            //PROBLEMA: adicionar mais elementos
            //SOLUÇÃO: usar o método Add
            empresas.Add(alura);
            empresas.Add(caelum);
            empresas.Add(casaDoCodigo);

            //PROBLEMA: começando com uma lista já populada
            //SOLUÇÃO: a mesma do array

            //List<string> empresas = new List<string>
            //{
            //    alura,
            //    caelum,
            //    casaDoCodigo
            //};

            //PROBLEMA: imprimir a lista
            //SOLUÇÃO: varrer os elementos da lista
            Imprimir(empresas);

            //PROBLEMA: Pegando o primeiro elemento
            //SOLUÇÃO: Usar índice, como no array
            Console.WriteLine("A primeira empresa é " + empresas[0]);

            //PROBLEMA: Pegando o último elemento
            //SOLUÇÃO: Usar índice, como no array
            Console.WriteLine("A última empresa é " + empresas[empresas.Count - 1]);

            //PROBLEMA: modificar elemento numa certa posição
            //SOLUÇÃO: acessar elemento pelo índice e atribuir novo valor
            empresas[0] = "Alura Cursos Online";
            Imprimir(empresas);

            //PROBLEMA: Reverter a sequência da lista
            //SOLUÇÃO: Usar método Reverse()
            empresas.Reverse();
            Imprimir(empresas);

            //PROBLEMA: Adicionar um novo elemento ao final
            //SOLUÇÃO: Usar método Add()
            empresas.Add("MusicDot");
            Imprimir(empresas);

            //PROBLEMA: Adicionar vários elementos ao final
            //SOLUÇÃO: Usar método AddRange()
            var maisEmpresas = new string[] { "empresa 1", "empresa 2" };
            empresas.AddRange(maisEmpresas);
            Imprimir(empresas);

            //PROBLEMA: adicionar novo elemento na segunda posição
            //SOLUÇÃO: Usar método Insert
            var posicao = 2;
            empresas.Insert(posicao - 2, "Hipsters.Jobs");
            Imprimir(empresas);

            //PROBLEMA: adicionar mais de um elemento na terceira posição
            //SOLUÇÃO: Usar método InsertRange()
            empresas.InsertRange(2, new string[] { "empresa 3", "empresa 4" });
            Imprimir(empresas);

            //PROBLEMA: Ordenar elementos
            //SOLUÇÃO: usar método sort
            empresas.Sort();
            Imprimir(empresas);

            //PROBLEMA: Ordenar elementos por ordem de tamanho de string
            //SOLUÇÃO: usar delegate Comparison e método CompareTo
            empresas.Sort((empresa1, empresa2) => empresa1.Length.CompareTo(empresa2.Length));
            Imprimir(empresas);

            //PROBLEMA: copiar os 2 últimos elementos para nova lista
            //SOLUÇÃO: Usar método GetRange()
            List<string> copia = empresas.GetRange(empresas.Count - 2, 2);
            Imprimir(copia);

            //PROBLEMA: clonar a lista
            //SOLUÇÃO: passar lista original no construtor da lista
            List<string> clone = new List<string>(empresas);
            Imprimir(clone);

            //PROBLEMA: remover um elemento
            //SOLUÇÃO: usar método Remove()
            empresas.Remove(alura);
            Imprimir(clone);

            //PROBLEMA: remover o último elemento
            //SOLUÇÃO: Usar método RemoveAt()
            empresas.RemoveAt(empresas.Count - 1);
            Imprimir(empresas);

            //PROBLEMA: remover os dois últimos elementos
            //SOLUÇÃO: Usar RemoveRange
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> empresas)
        {
            Console.WriteLine();
            //foreach (var empresa in empresas)
            //{
            //    Console.WriteLine(empresa);
            //}

            //Método ForEach: 
            //Executa uma ação (Action) para cada elemento do array
            empresas.ForEach(empresa => Console.WriteLine(empresa));
            Console.WriteLine();
        }
    }
}
