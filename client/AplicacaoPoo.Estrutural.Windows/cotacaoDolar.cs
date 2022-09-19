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
    public partial class frmCotacaoDoDolar : Form
    {
        public frmCotacaoDoDolar()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ExecutaCalculo();
        }

        private void txtValorDolar_Leave(object sender, EventArgs e)
        {
            ExecutaCalculo();
        }

        void ExecutaCalculo()
        {
            decimal cotacaoDolar;
            decimal valorDolar;
            decimal totalConvetido;

            cotacaoDolar = decimal.Parse(txtCotacaoDolar.Text);
            valorDolar = decimal.Parse(txtValorDolar.Text);
            totalConvetido = cotacaoDolar * valorDolar;
            txtConversor.Text = totalConvetido.ToString("N2");

            lblResultado.Text = "O Resultado é " + totalConvetido.ToString("N");
        }
    }
}
