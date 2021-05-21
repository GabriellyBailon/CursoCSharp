using System.Globalization;
namespace Encapsulamento002
{
    class Produto
    {
        //Atributos privados
        //_nome dos atributos privados seguem a regra: _nome
        private string _nome;
        private double _preco;
        private int _quantidade;

        //CONCEITO DE SOBRECARGA APLICADO AQUI
        //Construtor sem parâmetros
        public Produto()
        {

        }

        //Construtor com 2 parâmetros
        public Produto(string nome, double preco)
        {
            this._nome = nome;
            this._preco = preco;

            //Atribui a todo objeto da classe produto, automaticamente a quantidade abaixo
            this._quantidade = 5;
        }
        //Construtor com três parâmetros
        //Utilizamos o this aqui, para  referenciar e reaproveitar informações de outro construtor
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {

            this._quantidade = quantidade;
        }

        //Getters e Seters com Properties

        public string Nome
        {
            //O get fica quase a mesma coisa
            get { return _nome; }

            //Já o set troca todo lugar que receberia um parâmetro para value
            set {
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

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}