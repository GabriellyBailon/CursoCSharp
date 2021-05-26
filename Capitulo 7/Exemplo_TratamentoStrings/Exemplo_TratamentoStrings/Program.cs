using System;

namespace Exemplo_TratamentoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tTratamento de strings!");

            string original = "abcde FGHIJ ABC abc DEFG    ";
            Console.WriteLine($"\nOriginal: {original}-");

            string maiusculo = original.ToUpper();
            Console.WriteLine($"Em maiúsculo: {maiusculo}-");

            string minusculo = original.ToLower();
            Console.WriteLine($"Em minúsculo: {maiusculo}-");

            string semEspacos = original.Trim();
            Console.WriteLine($"Sem espaços: {semEspacos}-");

            //Retorna a posição do pedaço especificado
            int pos1 = original.IndexOf("bc") ;
            Console.WriteLine($"Primeira posição do 'bc': {pos1}");

            int pos2 = original.LastIndexOf("bc");
            Console.WriteLine($"Última posição do 'bc': {pos2}");

            //"Recortando" strings
            string substring1 = original.Substring(3);
            Console.WriteLine($"A partir da posição 3: {substring1}");

            string substring2 = original.Substring(3, 5);
            Console.WriteLine($"5 caracteres a partir da posição 3: {substring2}");

            //Replace
            //"Substitui caractéres por  outros"
            string substitui1 = original.Replace('a', 'x');
            Console.WriteLine($"Substituindo a por x: {substitui1}");

            string substitui2 = original.Replace("abc", "xy");
            Console.WriteLine($"Substituindo abc por xy: {substitui2}");

            bool vazioOuNao = String.IsNullOrEmpty(original);
            Console.WriteLine($"A string original está vazia? {vazioOuNao}");

            bool vazioOuEspaco = String.IsNullOrWhiteSpace(original);
            Console.WriteLine($"A string original está vazia ou só contém espaços? {vazioOuEspaco}");

        }
    }
}
