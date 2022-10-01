using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class Vendedor
    {
        //public const string Vendedor01 = " Yanna Felipe Brito";
        //public const string Vendedor02 = " Kauã Basilho Neves";
        //public const string Vendedor03 = " Pedro Henrique Felipe";
        //public const string Vendedor04 = " Pedro Eduardo Felipe ";

        //A classe const (constante) para usar em outra classe,logo não prevcisa usar o new para chamá-la.
        // Esse método permite foi refatorar para vira uma uma constante e o valor não poderá ser mudado em todo o sistema.
        public int Id { get; set; }
        public string Nome { get; set; }
    }
   


}

