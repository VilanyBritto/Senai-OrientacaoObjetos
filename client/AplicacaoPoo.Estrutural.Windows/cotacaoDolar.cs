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
        //abaixo variável global
        private bool CotacaoEhValido; //Controla visibilidade de propriedades e classe e não método.
        private bool ValorEmDolarEhValido; // Sempre que o método for Bool a afirmação inicial é falsa
        public frmCotacaoDoDolar()
        {
            InitializeComponent();
            HabilitarOuDesabilitarBotaoCalcularConversao();
        }


        private void btnCalcularResultado_Click(object sender, EventArgs e)
        {
            ExecutaCalculo();
        }

        private void ExecutaCalculo()
        //private void = é criar método sem retorno no escopo(encapsulado privado),  
        /* public void = é o método sem retorno no escopo(encapsulado publico)
        * o void é o mesmo sem retorno(o void é privado pois não classifiquei o visibilidade dele como publico ou privado 
        * O método tem retorno quando permite retornar algum valor ex: sting, double, decimal (public string, private string, string)
        * O método tem retorno quando permite retornar algum valor ex: sting, double, decimal (public string, private string, string)
       */
        {
            decimal cotacaoDolar;
            decimal valorDolar;
            decimal totalConvetido;

            cotacaoDolar = decimal.Parse(txtCotacaoDolar.Text);
            valorDolar = decimal.Parse(txtValorDolar.Text);
            totalConvetido = cotacaoDolar * valorDolar;
            txtConversor.Text = totalConvetido.ToString("N2");

            lblMostarResultado.Text = "O Resultado é " + totalConvetido.ToString("N2");
        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e) //analisa se o que digitou é valido ou não
        {
            try // try cath é tratamento de erro
            {
                var CalcularResultado = decimal.Parse(txtCotacaoDolar.Text);
                CotacaoEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
                // btnCalcularResultado.Enabled=true;
                //Enable é habilitar o botão 

            }
            catch (Exception)
            {
                MessageBox.Show("Digite um valor numérico");
                txtCotacaoDolar.Focus(); //textchanged precisa ser aplicado aí
                CotacaoEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();

            }
        }

        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var CalcularResultado = decimal.Parse(txtValorDolar.Text);
                ValorEmDolarEhValido = true;
                HabilitarOuDesabilitarBotaoCalcularConversao();
                // 
                //btnCalcularResultado.Enabled = true;


            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dólar é um valor decimal");
                txtCotacaoDolar.Focus();
                ValorEmDolarEhValido = false;
                HabilitarOuDesabilitarBotaoCalcularConversao();

                //MessageBox.Show(x.Message + ". \nContate o suporte!");
                //textchanged precisa ser aplicado aí 
                //  MessageBox.Show("Digite um valor numérico");

            }
        }
        //private void txtValorDolar_Leave(object sender, EventArgs e)
        /*Leave é um evento que irá execultar o método ExecutaCalculo() quando a caixa de texto perder o foco 
        /* (exemplo clicar na próxima caixa)
        {
            ExecutaCalculo();
        }*/
        private void HabilitarOuDesabilitarBotaoCalcularConversao()
        {
            if (ValorEmDolarEhValido && CotacaoEhValido)
            {
                btnCalcularResultado.Enabled = true;
            }
            else
            {
                btnCalcularResultado.Enabled = false;
            }
        }

    
    }
}
        
        