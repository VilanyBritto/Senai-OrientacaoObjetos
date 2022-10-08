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
            var produtoService = new ProdutoService();
            cboProduto.DataSource = produtoService.ListagemProdutosFake();
            cboProduto.DisplayMember = "Nome";
        }

        private void lblDescricaoProduto_Click(object sender, EventArgs e)
        {
            var dadosPedido = new VendedorService();
                                         
        }
    }

}