using System.Globalization;
namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //CONCEITO DE SOBRECARGA APLICADO AQUI
        //Construtor sem parâmetros
        public Produto()
        {

        }


        //Construtor com 2 parâmetros
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;

            //Atribui a todo objeto da classe produto, automaticamente a quantidade abaixo
            this.Quantidade = 5;
        }
        //Construtor com três parâmetros
        //Utilizamos o this aqui, para  referenciar e reaproveitar informações de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {

            this.Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
