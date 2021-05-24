using System;
using System.Collections.Generic;       //Necessita da biblioteca "System.Collections.Generic"

namespace Exemplo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo List/Lista");

            //Declaração de uma lista
            List<string> lista = new List<string>();

            //Adicionando itens
            lista.Add("Maria");
            lista.Add("Alex");
            lista.Add("Bob");
            lista.Add("Anna");

            //Usando o insert (escolhendo a posição onde o objeto será inserido)
            lista.Insert(2, "Marco");

            //Imprimindo os itens de uma lista usando o foreach
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------------------------------------");

            //Mostrando o tamanho da lista com o Count
            Console.WriteLine($"A lista tem {lista.Count} elementos");

            //Usando o Find e Expressão Lambda como predicado

            //Encontrar na lista o primeiro ITEM que tem A como primeira letra
            string s1 = lista.Find(x => x[0] == 'A');
            Console.WriteLine($"\nO primeiro item encontardo que começa com a letra A é {s1}");

            //Encontrar na lista o último ITEM que tem A como primeira letra
            string s2 = lista.FindLast(x => x[0] == 'A');
            Console.WriteLine($"\nO último item encontardo que começa com a letra A é {s2}");

            //Encontrar na lista a POSIÇÃO do item que tem A como primeira letra
            int pos1 = lista.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"\nA posição do primeiro item encontardo que começa com a letra A é {pos1}");

            //Encontrar na lista a POSIÇÃO do item que tem A como primeira letra
            int pos2 = lista.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"\nA posição do último item encontardo que começa com a letra A é {pos2}");

            //Filtrando a lista

            //Criar uma nova lista, passando a condição
            List<string> listaFiltrada = lista.FindAll(x => x.Length == 5);

            //Imprimindo lista filtrada
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Nomes com 5 letras: ");

            //Criada uma função que imprime uma lista mais abaixo no código atual
            ImprimeLista(lista);

            //Removendo itens

            //O Remove espera um string para remover da lista,
            //só remove se o elemento estiver escrito totalmente de forma correta
            lista.Remove("Alex");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Alex removido");
            ImprimeLista(lista);

            //O RemoveAt espera um int para remover o item na posição passada como parâmetro
            lista.RemoveAt(2);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Removido quem estava na posição 2");
            ImprimeLista(lista);

            //O RemoveRange remove a partir da posição n, x itens
            lista.RemoveRange(2, 1);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("A partir da posição 2, 1 elemento é removido");
            ImprimeLista(lista);

            //O RemoveAll espera um predicado como parâmetro para realizar a remoção
            lista.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("Removido quem começava com a letra M");
            ImprimeLista(lista);




            //Observações:
            //Podem ser adicionados objetos;

        }

        static void ImprimeLista(List <string> lista)
        {
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
