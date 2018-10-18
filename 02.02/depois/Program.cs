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

            empresas = new List<string> { alura, caelum, casaDoCodigo };

            //PROBLEMA: imprimir a lista
            //SOLUÇÃO: varrer os elementos da lista

            Imprimir(empresas);

            #region problemas
            ///PROBLEMA: Pegando o primeiro elemento
            ///SOLUÇÃO: Usar índice, como no array
            ///PROBLEMA: Pegando o último elemento
            ///SOLUÇÃO: Usar índice, como no array
            ///PROBLEMA: modificar elemento numa certa posição
            ///SOLUÇÃO: acessar elemento pelo índice e atribuir novo valor
            ///PROBLEMA: Reverter a sequência da lista
            ///SOLUÇÃO: Usar método Reverse()
            ///PROBLEMA: Adicionar um novo elemento ao final
            ///SOLUÇÃO: Usar método Add()
            ///PROBLEMA: Adicionar vários elementos ao final
            ///SOLUÇÃO: Usar método AddRange()
            ///PROBLEMA: adicionar novo elemento na segunda posição
            ///SOLUÇÃO: Usar método Insert
            ///PROBLEMA: adicionar mais de um elemento na terceira posição
            ///SOLUÇÃO: Usar método InsertRange()
            ///PROBLEMA: Ordenar elementos
            ///SOLUÇÃO: usar método sort
            ///PROBLEMA: Ordenar elementos por ordem de tamanho de string
            ///SOLUÇÃO: usar delegate Comparison e método CompareTo
            ///PROBLEMA: copiar os 2 últimos elementos para nova lista
            ///SOLUÇÃO: Usar método GetRange()
            ///PROBLEMA: clonar a lista
            ///SOLUÇÃO: passar lista original no construtor da lista
            ///PROBLEMA: remover um elemento
            ///SOLUÇÃO: usar método Remove()
            ///PROBLEMA: remover o último elemento
            ///SOLUÇÃO: Usar método RemoveAt()
            ///PROBLEMA: remover os dois últimos elementos
            ///SOLUÇÃO: Usar RemoveRange
            #endregion
        }

        private static void Imprimir(List<string> empresas)
        {
            //for (int i = 0; i < empresas.Count; i++)
            //{
            //    var empresa = empresas[i];
            //    Console.WriteLine(empresa);
            //}

            //foreach (var empresa in empresas)
            //{
            //    Console.WriteLine(empresa);
            //}

            empresas.ForEach( (empresa) => 
            {
                Console.WriteLine(empresa);
            });
        }
    }
}
