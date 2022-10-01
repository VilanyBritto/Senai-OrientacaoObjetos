using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    public class VendedorService
    {
        public List<Vendedor> ListagemVendedorFake()
        {
            var lista = new List<Vendedor>();

            lista.Add(new Vendedor()
            {
                Id = 1,
                Nome = "Claudio",
              
            });
            lista.Add(new Vendedor()
            {
                Id = 2,
                Nome = "Maria",
               
            });
            lista.Add(new Vendedor()
            {
                Id = 3,
                Nome = "João",
            });
            return lista;
        }
    }
}
