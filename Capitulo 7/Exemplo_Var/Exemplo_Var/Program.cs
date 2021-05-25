using System;

namespace Exemplo_Var
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usando o var");
            Console.WriteLine("A linguagem consegue inferir o tipo da variável");
            Console.WriteLine("Auxilia muito nas tarefas do dia-a-dia mas é preciso usá-la com muito cuidado");

            //A linguagem infere o tipo da variável
            //Só é possível usar se tiver a declaração na mesma linha
            //Pode receber objetos

            var x = 15;
            var y = 8.0;
            var z = "Maria";

            Console.WriteLine(x + " " + y + " " + z);
        }
    }
}
