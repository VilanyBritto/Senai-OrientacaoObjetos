using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cotacaoDoDolar(object sender, EventArgs e)
        {
            //frmCotacaoDoDolar frmCotacaoDoDolar = new frmCotacaoDoDolar(); (O comando desta linha funciona, mas servirá para abrir este formulário, se usar o var com na linha abaixo ele poderá converter)
            var form = new frmCotacaoDoDolar();
            form.Show();
        }

        private void btnControleVendedor_Click(object sender, EventArgs e)
        {
          //btnControleVendedor.Enabled = new frmcontroleVendedor
            var form = new frmControleComissao();
            form.Show();
        }
    }
}
