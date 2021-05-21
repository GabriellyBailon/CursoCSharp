using System.Globalization;
namespace Encapsulamento003_Properties
{
    class Produto
    {
        //Propriedades
        //As que não tem métodos com regras diferentes para getters e setters, podem usar as propriedades
        //As outras usam métodos separados como, por exemplo, GetNome() e SetNome()
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //CONCEITO DE SOBRECARGA APLICADO AQUI
        //Construtor sem parâmetros
        public Produto()
        {

        }

        //Construtor com 2 parâmetros
        public Produto(string nome, double preco)
        {
            this._nome = nome;
            Preco = preco;

            //Atribui a todo objeto da classe produto, automaticamente a quantidade abaixo
            this.Quantidade = 5;
        }
        //Construtor com três parâmetros
        //Utilizamos o this aqui, para  referenciar e reaproveitar informações de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {

            this.Quantidade = quantidade;
        }

        //Getters e Seters com Properties

        public string Nome
        {
            //O get fica quase a mesma coisa
            get { return _nome; }

            //Já o set troca todo lugar que receberia um parâmetro para value
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }

        //Quando valores, por segurança e regras de negócio,  não puderem ser alterados diretamente pelo usuário,
        //Implementar as alterações a serem feitas e apenas o get do atributo
        //Nesse caso, faremos isso com preco e quantidade

        //A quantidade só poderá ser alterada pelos métodos AdicionarProdutos() ou RemoverProdutos()

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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}