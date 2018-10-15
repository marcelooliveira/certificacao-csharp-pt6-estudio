using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace _01._05
{
    [Serializable]
    public class LojaDeFilmes
    {
        public List<Diretor> Diretores = new List<Diretor>();
        public List<Filme> Filmes = new List<Filme>();
        public static void AdicionarFilme(Filme filme)
        {
            // Aqui vai a lógica de inserção de filme...
        }
    }

    [Serializable]
    public class Diretor : ISerializable
    {
        public string Nome { get; set; }
        public int NumeroFilmes;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("nome", Nome);
            info.AddValue("numeroFilmes", NumeroFilmes);
        }

        [OnSerializing]
        internal void OnSerializing(StreamingContext streamingContext)
        {
            Console.WriteLine("antes de serializar o diretor");
        }

        [OnSerialized]
        internal void OnSerialized(StreamingContext streamingContext)
        {
            Console.WriteLine("depois de serializar o diretor");
        }
    }

    [Serializable]
    public class Filme
    {
        public Diretor Diretor { get; set; }
        public string Titulo { get; set; }
        public string Ano { get; set; }
    }
}
