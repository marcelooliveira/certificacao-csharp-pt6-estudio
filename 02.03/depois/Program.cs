using System;
using System.Collections.Generic;

namespace _02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);

            //DICIONÁRIO

            //declarando dicionário de filmes

            //adicionando: 34672-esperanca, 5617-imperio, 17645-retorno

            //Imprimindo os filmes cadastrados

            //Um dicionário permite associar uma chave (ID do filme) a um valor (o filme)

            //Qual é o filme com ID 34672?

            //e se tentarmos adicionar outro filme com mesma chave 34672?

            //e se quisermos trocar o filme que tem a mesma chave?

            //pergunta: "Quem é o Filme 34672 agora?"

            //buscando uma chave que não existe: 34673

            //verificando se a chave 34673 existe

            //buscando uma chave 34673 de forma segura

            //Como um dicionário armazena os valores (diagrama)
            ///<image url="$(ProjectDir)\image.png" scale=""/>
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
            Filme outra = obj as Filme;
            if (outra == null)
            {
                return false;
            }

            return outra.Titulo.Equals(this.Titulo)
                && outra.Ano.Equals(this.Ano);
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
