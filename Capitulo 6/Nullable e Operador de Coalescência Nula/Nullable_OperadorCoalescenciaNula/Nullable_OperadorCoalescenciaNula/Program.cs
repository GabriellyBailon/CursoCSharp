using System;

namespace Nullable_OperadorCoalescenciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erro
            //double x = null;

            //"Por extenso"
            Nullable<double> n1 = null;

            //Modo mais utilizado
            double? x = null;

            Console.WriteLine(x);

            //Métodos com o Nullable

            //Pega o valor da variável ou o padrão do tipo
            //Nesse caso, o padrão do tipo double, é 0
            Console.WriteLine(x.GetValueOrDefault());

            //O HasValue verifica se tem valor (true) ou não (false) na variável.
            //Como aqui, o x recebe null, o HasValue retorna false.
            Console.WriteLine(x.HasValue);

            //Value : Retorna o valor em si
            //Lança exceção se recebe uma variável com valor null
            //Console.WriteLine(x.Value);

            //Como resolver (sem o uso de exceções ainda)
            if (x != null)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("A variável em questão tem valor null");
            }

            //Agora vamos entender o operador ??
            //Temos o x = null e o y
            double? y = 10;

            double a, b;

            //Aqui temos que a recebe x se x não for nulo, se x for nulo, a recebe o valor após o "??"
            //O operador ?? pergunta, essa variavel antes de mim é nula? Se for, atribuímos o outro valor
            //Já que o tipo double, não aceita "naturalmente" um valor null
            a = x ?? 5.0;
            b = y ?? 5.0;
            
            //Aqui, x é nulo, então a recebe o valor 5
            Console.WriteLine(a);

            //Já nesse caso, y não é nulo, então b, recebe o valor de y que é 10
            Console.WriteLine(b);

        }
    }
}
