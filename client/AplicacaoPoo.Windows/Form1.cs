using AplicacaoPoo.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Windows
{
    public partial class frmCliente : Form // nome da classe
    {
        private object txtNome;

        public frmCliente() // é o construtor da classe
        {
            InitializeComponent(); // Sempre que for usar uma classe como ferência precisa adicionar a referencia dela no using,
            var cliente = new Cliente();
            cliente.Nome = "Lany Britto"; //set de Lany Britto para dentro de nome ao contrário é get. quando não quero que o codigo seja modificado eu uso o set.
            textNome.Text = cliente.Nome;
            textCpf.Text = "123.456.789-00";
            lblSaldoInicialValor.Text = "1000";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var credito = new Credito();

        }
    }
}
