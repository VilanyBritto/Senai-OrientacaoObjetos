using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class Cliente // visibilidade da classe, abaixo são as propriedades e o tipo de visibilidade e o tipo da dado bloqeio a ser usado ou não
    {  
       public string Nome { get; set; } //string tipo primitivo
       public string Cpf { get; set; } //tipo complexo
        //prop são codigo de comando 
        public double SaldoInicial { get; set; }
       public  Debito Debito { get; set; } //get e set é permitir que qualquer consiga colocar informação, quando não quero que o codigo seja modificado eu uso o set.
        public Credito Credito { get; set; }
    }
}
