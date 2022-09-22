using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    //static = As classes estáticas são aquelas que contêm apenas membros estáticos (é o que está dentro) não pode ser instanciada (não pode usar o new ( new = receber).
    /*partical = 
     * abstract =
     */
    public class ConverterMoedaService 
        // classe para converter todo o valor que o usuário digita em: euro, libras e dólar.
        /* Visível apenas para este projeto. Era internal e mudamos para public
         */
    {
        decimal CotacaoDolar = 5.25m;
        decimal CotacaoLibra = 6.15m;
        decimal CotacaoEuro = 6.0m;
       public decimal ConverterDolarEmReal (decimal valor)
        {
            return valor * CotacaoDolar;
        }

        public decimal ConverterLibrasEmReal (decimal valor)
        {
            return valor * CotacaoLibra;
        }
        public decimal ConverterEuroEmReal (decimal valor)
        {
            return valor * CotacaoEuro;
        }
    }
}
