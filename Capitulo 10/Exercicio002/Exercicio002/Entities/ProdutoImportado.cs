using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio002.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) 
            : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double TotalPreco()
        {
            return Preco += TaxaAlfandega;
        }

        public override string PriceTag()
        {
            return $"{Nome} ${TotalPreco().ToString("F2")} " +
                $"Taxa de alfândega: ${TaxaAlfandega.ToString("F2")}";
        }
    }
}
