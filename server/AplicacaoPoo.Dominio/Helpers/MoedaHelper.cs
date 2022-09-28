using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.Helpers
{
    //Era internal class MoedaHelper = Classe para ponto de concentração de ponto de moeda, mudamos para abaixo
    public static class MoedaHelper  //
        {
            public const string Real = " Real Brasileiro";
            public const string Dolar = " Dolar Americano";
            public const string Euro = " Euro";
            public const string Libras = " Libras Esterlinas";
        //A classe era static string e mudamos para const de constante para usar em outra classe,logo não prevcisa usar o new para chamá-la.
        // Esse método permite foi refatorar para vira uma uma constante e o valor não poderá ser mudado em todo o sistema.
        }
    
}
