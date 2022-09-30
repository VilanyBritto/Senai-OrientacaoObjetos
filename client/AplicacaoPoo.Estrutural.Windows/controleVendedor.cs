using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;
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
            #region Meu Programa
            //    string vendedor;
            //    int codigo;
            //    Double valorUnitario;
            //    Double qtd;

            //    vendedor = txtNomeVendedor.Text;
            //    codigo = int.Parse(txtCodigoDaPeca.Text);
            //    valorUnitario = Double.Parse(txtPrecoUnitario.Text);
            //    txtPrecoUnitario.Text = valorUnitario.ToString("N2");
            //    qtd = Double.Parse(txtQuantidade.Text);

            //    //lblComissao.Text = "Comissão: " + vendedor;

            //    lblResultado.Text = $"Vendedor: {vendedor} \nCódigo do produto vendido: {codigo} \nQuantidade: {qtd} \nComissão total: {((valorUnitario * qtd) * 0.05).ToString("N2")} \n ";
            //    #region MEU PROGRAMA
            //    // txtCodigoDaPeca.Text = "";
            //    // txtPrecoUnitario.Text = "";
            //    // txtQuantidade.Text = "";
            //    #endregion
            //    txtCodigoDaPeca.Focus(); // O comando Focus() nesta linha é para direcionar o cursos para o campo txtCodigoDaPeca sempre que preencher o ultimo campo solicitado.
            #endregion

        }

        private void frmControleComissao_Load(object sender, EventArgs e)
        { 
            int valorUnitarioProduto;
            int CodigoProduto;
            string selecionarProduto;
            string descricaoProduto;
            int produtoSelecionado;
            int valorTotalPedido;
            string botaoRegistrar;



            lblInformacoesDoPedido = $"Vendedor: {cboNomeVendedor}" 
        }

        private void cboNomeVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNomeVendedor.Text == "") return;
                var nomeVendedor = cboNomeVendedor.Text;


                switch (cboNomeVendedor.SelectedValue)
                {
                    case Vendedores.Yanna:
                        {

                            break;
                        }
                    case Vendedores.Kaua:
                        {


                            break;
                        }
                    case Vendedores.Pedro:
                        {


                            break;
                        }
                    case Vendedores.Eduardo:
                        {


                            break;
                        }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar o valor numérico");
                txtQuantidade.Text = String.Empty;
                txtQuantidade.Focus();
            }
        }



    }

}