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
    public partial class frmControleComissao : Form
    {
        public frmControleComissao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vendedor;
            int codigo;
            Double valorUnitario;
            Double qtd;

            vendedor = txtNomeVendedor.Text;
            codigo = int.Parse(txtCodigoDaPeca.Text);
            valorUnitario = Double.Parse(txtPrecoUnitario.Text);
            txtPrecoUnitario.Text = valorUnitario.ToString("N2");
            qtd = Double.Parse(txtQuantidade.Text);

            //lblComissao.Text = "Comissão: " + vendedor;

            lblResultado.Text = $"Vendedor: {vendedor} \nCódigo do produto vendido: {codigo} \nQuantidade: {qtd} \nComissão total: {((valorUnitario * qtd) * 0.05).ToString("N2")} \n ";
            #region MEU PROGRAMA
            // txtCodigoDaPeca.Text = "";
            // txtPrecoUnitario.Text = "";
            // txtQuantidade.Text = "";
            #endregion
            txtCodigoDaPeca.Focus(); // O comando Focus() nesta linha é para direcionar o cursos para o campo txtCodigoDaPeca sempre que preencher o ultimo campo solicitado.
        }

        private void frmControleComissao_Load(object sender, EventArgs e)
        {

        }
    }
}
