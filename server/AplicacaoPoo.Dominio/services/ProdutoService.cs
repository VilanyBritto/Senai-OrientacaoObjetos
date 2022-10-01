using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class ProdutoService
    {
        public List<Produto> ListagemProdutosFake()
        {
            var lista = new List<Produto>();

            lista.Add(new Produto()
            {
                Id = 100,
                Nome = "Camiseta",
                ValorUnitario = 15m
            });
            lista.Add(new Produto()
            {
                Id = 101,
                Nome = "Boné",
                ValorUnitario = 10m
            });
            lista.Add(new Produto()
            {
                Id = 102,
                Nome = "Meia",
                ValorUnitario = 12m
            });
            return lista;
        }
    }
}
