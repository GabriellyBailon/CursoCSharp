using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio002.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }
        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " " + DataDeFabricacao.ToString("dd/MM/yyyy");
        }
    }
}
