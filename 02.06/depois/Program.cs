using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._06
{
    class Program
    {
        static List<string> placas = new List<string>();

        static void Main(string[] args)
        {
            Adicionar("FND-7714");
            Adicionar("ABC-1234");
            Adicionar("XYZ-9987");

            foreach (var placa in placas)
            {
                Console.WriteLine(placa);
            }

            //PROBLEMA: CRIAR UMA COLEÇÃO DE PLACAS DE CARRO VÁLIDAS
            //SOLUÇÃO: CRIAR UMA COLEÇÃO PERSONALIZADA
        }

        private static void Adicionar(string numero)
        {
            if (!EhPlacaValida(numero))
            {
                throw new ArgumentException("Placa inválida: " + numero);
            }
            placas.Add(numero);
        }

        static bool EhPlacaValida(string value)
        {
            Regex regex = new Regex(@"^[A-Z]{3}\-\d{4}$");

            if (regex.IsMatch(value))
            {
                return true;
            }

            return false;
        }

    }
}
