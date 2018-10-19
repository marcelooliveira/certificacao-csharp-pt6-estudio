using System;
using System.Collections.Generic;

namespace _02._02
{
    class Program
    {
        //Cronologia Star Wars
        //=========================================
        //Episódio I: A Ameaça Fantasma         1999
        //Episódio II: Ataque dos Clones        2002
        //A Guerra dos Clones                   2003
        //Episódio III: A Vingança dos Sith     2005
        //Rebels                                2014
        //Rogue One                             2016
        //Episódio IV -Uma nova esperança       1977
        //Episódio V -O Império Contra-Ataca    1980
        //Episódio VI -O Retorno de Jedi        1983
        //Episódio VII -O Despertar da Força    2015
        //Episódio VIII: Os Últimos Jedi        2017
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);
            var ataque = new Filme("Episódio II: Ataque dos Clones", 2002);
            var guerraClones = new Filme("A Guerra dos Clones", 2003);
            var vinganca = new Filme("Episódio III: A Vingança dos Sith", 2005);
            var rebels = new Filme("Rebels", 2014);
            var despertar = new Filme("Episódio VII -O Despertar da Força", 2015);
            var rogue = new Filme("Rogue One", 2016);
            var ultimo = new Filme("Episódio VIII: Os Últimos Jedi", 2017);

            List<Filme> cronologia = new List<Filme>();
            Console.WriteLine("cronologia.Capacity: " + cronologia.Capacity);

            cronologia.Add(esperanca);

            cronologia.AddRange(new[] { imperio, retorno });

            //List<Filme> cronologia = new List<Filme>()
            //{
            //    esperanca,
            //    imperio,
            //    retorno,
            //};

            Console.WriteLine("cronologia.Capacity: " + cronologia.Capacity);

            Imprimir(cronologia);

            cronologia.Insert(0, ameaca);
            Imprimir(cronologia);


            cronologia.InsertRange(1, new [] { ataque, guerraClones, vinganca, rebels });
            Imprimir(cronologia);

            Console.WriteLine("cronologia.Capacity: " + cronologia.Capacity);
            cronologia.Add(despertar);
            Imprimir(cronologia);

            var indiceEsperanca = cronologia.IndexOf(esperanca);
            cronologia.Insert(indiceEsperanca, rogue);
            Imprimir(cronologia);

            cronologia.Add(ultimo);
            Imprimir(cronologia);

            cronologia.Reverse();
            Imprimir(cronologia);
            cronologia.Reverse();
            Imprimir(cronologia);

            var filmesComAtores = new List<Filme>(cronologia);
            var indiceGuerraClones = filmesComAtores.IndexOf(guerraClones);
            filmesComAtores.RemoveAt(indiceGuerraClones);
            filmesComAtores.Remove(rebels);
            Imprimir(filmesComAtores);

            var trilogiaOriginal = new List<Filme>(filmesComAtores);
            trilogiaOriginal.RemoveAll((f) => f.Ano > 1983);
            Imprimir(trilogiaOriginal);

            Console.WriteLine("O primeiro filme da cronologia é " + cronologia[0]);
            Console.WriteLine("O último filme da cronologia é " + cronologia[cronologia.Count - 1]);

            var ordemAlfabetica = new List<Filme>(filmesComAtores);
            ordemAlfabetica.Sort();
            Imprimir(ordemAlfabetica);
            
            var ordemLancamento = new List<Filme>(filmesComAtores);
            ordemLancamento.Sort((f1, f2) => f1.Ano.CompareTo(f2.Ano));
            Imprimir(ordemLancamento);

            var trilogiaInicial = new Filme[3];
            ordemLancamento.CopyTo(3, trilogiaInicial, 0, 3);
            Imprimir(trilogiaInicial);
        }

        private static void Imprimir(IEnumerable<Filme> cronologia)
        {
            foreach (var filme in cronologia)
            {
                Console.WriteLine(filme);
            }
            Console.WriteLine();
        }
    }

    public class Filme : IComparable
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public int CompareTo(object obj)
        {
            Filme este = this;
            Filme outro = obj as Filme;

            if (outro == null)
            {
                return -1;
            }
            return este.Titulo.CompareTo(outro.Titulo);
        }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }
    }
}
