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
            //TAREFA PRINCIPAL
            //=================
            //colocar os filmes abaixo na ordem cronológica
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

            //TAREFA: criar uma coleção vazia, que irá crescer aos poucos
            List<Filme> cronologia = new List<Filme>();

            //TAREFA: checar a capacidade da lista
            Console.WriteLine("cronologia.Capacity: " + cronologia.Capacity);

            //TAREFA: adicionar o filme "Episódio IV -Uma nova esperança"
            cronologia.Add(esperanca);

            //TAREFA: checar novamente a capacidade da lista
            Console.WriteLine("cronologia.Capacity: " + cronologia.Capacity);

            //TAREFA: Adicionar no final: Império Contra Ataca e Retorno de Jedi
            cronologia.AddRange(new[] { imperio, retorno });

            //TAREFA: Declarar a lista com inicialização simplificada
            //List<Filme> cronologia = new List<Filme>()
            //{
            //    esperanca,
            //    imperio,
            //    retorno,
            //};

            //TAREFA: checar novamente a capacidade da lista
            Console.WriteLine("cronologia.Capacity: " + cronologia.Capacity);

            //TAREFA: imprimir a cronologia
            Imprimir(cronologia);

            //TAREFA: inserir Ameaça Fantasma no início da cronologia
            cronologia.Insert(0, ameaca);
            Imprimir(cronologia);

            //TAREFA: Inserir na segunda posição: Ataque dos Clones, Guerra dos Clone, Vingança dos Sith
            cronologia.InsertRange(1, new [] { ataque, guerraClones, vinganca, rebels });
            Imprimir(cronologia);

            //TAREFA: checar novamente a capacidade da lista
            Console.WriteLine("cronologia.Capacity: " + cronologia.Capacity);

            //TAREFA: adicionar Despertar da Força no fim da cronologia
            cronologia.Add(despertar);
            Imprimir(cronologia);

            //TAREFA: inserir Rogue One antes de Uma Nova Esperança
            var indiceEsperanca = cronologia.IndexOf(esperanca);
            cronologia.Insert(indiceEsperanca, rogue);
            Imprimir(cronologia);

            //TAREFA: adicionar O Último Jedi ao final da cronologia
            cronologia.Add(ultimo);
            Imprimir(cronologia);

            //TAREFA: exibir a cronologia inversa
            cronologia.Reverse();
            Imprimir(cronologia);
            
            //TAREFA: voltar a cronologia à ordem original
            cronologia.Reverse();
            Imprimir(cronologia);

            //TAREFA: obter lista de filmes com atores
            var filmesComAtores = new List<Filme>(cronologia);
            var indiceGuerraClones = filmesComAtores.IndexOf(guerraClones);
            filmesComAtores.RemoveAt(indiceGuerraClones);
            filmesComAtores.Remove(rebels);
            Imprimir(filmesComAtores);

            //TAREFA: obter trilogia original (filmes lançados até 1983)
            var trilogiaOriginal = new List<Filme>(filmesComAtores);
            trilogiaOriginal.RemoveAll((f) => f.Ano <= 1983);
            Imprimir(trilogiaOriginal);

            //TAREFA: exibir primeiro filme da cronologia
            Console.WriteLine("O primeiro filme da cronologia é " + cronologia[0]);
            
            //TAREFA: exibir último filme da cronologia
            Console.WriteLine("O último filme da cronologia é " + cronologia[cronologia.Count - 1]);

            //TAREFA: exibir filmes em ordem alfabética
            var ordemAlfabetica = new List<Filme>(filmesComAtores);
            ordemAlfabetica.Sort();
            Imprimir(ordemAlfabetica);

            //TAREFA: exibir filmes em ordem de lançamento
            var ordemLancamento = new List<Filme>(filmesComAtores);
            ordemLancamento.Sort((f1, f2) => f1.Ano.CompareTo(f2.Ano));
            Imprimir(ordemLancamento);

            //TAREFA: exibir filmes da trilogia inicial (posições 4, 5 e 6)
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
