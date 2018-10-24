using System;
using System.Collections.Generic;

namespace _02._05
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            //COLEÇÃO: FILA
            //Regra: primeiro que entra é o primeiro que sai

            //TAREFA: Implementar uma fila de pedágio

            ///<image url="$(ProjectDir)\Slides\queue0.png" scale=""/>


            //entrou: van          
            string veiculo = "van";
            Enfileirar(veiculo);
            Imprimir();

            ///<image url="$(ProjectDir)\Slides\queue1.png" scale=""/>
            //entrou: kombi
            Enfileirar("kombi");
            Imprimir();

            ///<image url="$(ProjectDir)\Slides\queue2.png" scale=""/>
            //entrou: guincho
            Enfileirar("guincho");
            Imprimir();
            ///<image url="$(ProjectDir)\Slides\queue3.png" scale=""/>
            //entrou: pickup
            Enfileirar("pickup");
            Imprimir();

            ///<image url="$(ProjectDir)\Slides\queue4.png" scale=""/>

            //carro liberado
            Desenfileirar();

            ///<image url="$(ProjectDir)\Slides\queue5.png" scale=""/>
            //carro liberado
            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue6.png" scale=""/>
            //carro liberado
            Desenfileirar();
            ///<image url="$(ProjectDir)\Slides\queue7.png" scale=""/>
            //carro liberado
            Desenfileirar();

            //carro liberado
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            var liberado = pedagio.Dequeue();
            Console.WriteLine("Saiu do pedágio: " + liberado);
            Imprimir();
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine("Entrou no pedágio: " + veiculo);
            pedagio.Enqueue(veiculo);
        }

        private static void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("CONTEÚDO DA FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}
