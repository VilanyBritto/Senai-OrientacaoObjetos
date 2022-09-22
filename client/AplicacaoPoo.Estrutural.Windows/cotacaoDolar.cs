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
            InitializeComponent(); // esse inicialize vai iniciar tudo o que o compoe.
            btnCalcularResultado.Enabled = true;
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

            var valorEmDolar = decimal.Parse(txtValorDolar.Text);
            var moeda = new ConverterMoedaService();
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

            //string interpolation
            MessageBox.Show($"Valor convertido é: {resultado}em dolares");

        }



        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtValorDolar.Text == "")
                {
                    btnCalcularResultado.Enabled = false;
                    return;
                }
                var CalcularResultado = decimal.Parse(txtValorDolar.Text);
                btnCalcularResultado.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dólar é um valor decimal");
                txtValorDolar.Focus();
                btnCalcularResultado.Enabled = false;

                //MessageBox.Show(x.Message + ". \nContate o suporte!");
                //textchanged precisa ser aplicado aí 
                //  MessageBox.Show("Digite um valor numérico");

            }

        }

        private void txtValorDolar_Leave(object sender, EventArgs e)
        {
            //private void txtValorDolar_Leave(object sender, EventArgs e)
            /*Leave é um evento que irá execultar o método ExecutaCalculo() quando a caixa de texto perder o foco 
            /* (exemplo clicar na próxima caixa)
            {
                ExecutaCalculo();
            }*/


        }
    }
}
        
        