using System;
using System.Collections.Generic;

namespace _02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);
            var ataque = new Filme("Episódio II: Ataque dos Clones", 2002);
            var vinganca = new Filme("Episódio III: A Vingança dos Sith", 2005);
            var despertar = new Filme("Episódio VII -O Despertar da Força", 2015);
            var rogue = new Filme("Rogue One", 2016);
            var ultimo = new Filme("Episódio VIII: Os Últimos Jedi", 2017);

            //SETS = CONJUNTOS

            //Duas características do Set (conjunto)
            //1. não permite duplicidade
            //2. os elementos não são mantidos em ordem específica

            //declarando set de filmes
            ISet<Filme> filmes = new HashSet<Filme>();
            //adicionando: esperanca, imperio, retorno
            filmes.Add(esperanca);
            filmes.Add(imperio);
            filmes.Add(retorno);

            ///Imprime os filmes separados por vírgula
            Imprimir(filmes);
            
            //qual a diferença para uma lista?? vamos ver agora
            
            //adicionando: ameaca, ataque, vinganca
            filmes.Add(ameaca);
            filmes.Add(ataque);
            filmes.Add(vinganca);
            
            Imprimir(filmes);

            //e a ordem???

            //removendo imperio, adicionando despertar
            filmes.Remove(imperio);
            filmes.Add(despertar);

            //imprimindo de novo
            Imprimir(filmes);

            //adicionando vinganca de novo - não gera erro de duplicidade!
            filmes.Add(vinganca);
            Imprimir(filmes);

            //qual a vantagem do set sobre a lista? tempo de pesquisa!
            //https://stackoverflow.com/a/10762995

            //desempenho HashSet x List: escalabilidade X memória

            //desvantagem: consumo de memória

            //ordenando: sort
            //filmes.Sort();
            //copiando: filmesEmLista
            List<Filme> filmesEmLista = new List<Filme>(filmes);
            //ordenando copia
            filmesEmLista.Sort();

            //imprimindo copia
            Imprimir(filmesEmLista);

            //verificando se objeto existe
            Console.WriteLine("O filme Uma Nova Esperança existe? " + filmes.Contains(esperanca));
            var novaEsperanca = new Filme("Episódio IV -Uma nova esperança", 1977);

            Console.WriteLine("O filme Uma Nova Esperança existe? " + filmes.Contains(novaEsperanca));
        }

        private static void Imprimir(IEnumerable<Filme> filmes)
        {
            foreach (var filme in filmes)
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
            Filme esta = this;
            Filme outra = obj as Filme;

            if (outra == null)
            {
                return 1;
            }

            return esta.Titulo.CompareTo(outra.Titulo);
        }

        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }

        public override bool Equals(object obj)
        {
            Filme outro = obj as Filme;
            if (outro == null)
            {
                return false;
            }

            return this.Titulo.Equals(outro.Titulo) &&
                this.Ano.Equals(outro.Ano);
        }

        public override int GetHashCode()
        {
            var hashCode = -131496797;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titulo);
            hashCode = hashCode * -1521134295 + Ano.GetHashCode();
            return hashCode;
        }
    }
}
