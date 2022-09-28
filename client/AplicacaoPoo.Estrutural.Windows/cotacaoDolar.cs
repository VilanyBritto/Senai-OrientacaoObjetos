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
    public partial class frmCotacaoDoDolar : Form
    {
        private object valorEmDolar;
        private object resultado;

        public frmCotacaoDoDolar() //construtor
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
            txtValorEmDolar.Text = "1";
         // cboxValorPossivelConversao.Text = $"{MoedaHelper.Dolar}";
            var list = new List<string>();
            
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Libras);
            list.Add(MoedaHelper.Euro);
            cboxValorPossivelConversao.DataSource = list;
            cboxValorPossivelConversao.SelectedIndex = 0;

        }

        private void txtValorDolar_TextChanged(object sender, EventArgs e)
        { // Execulta o método quando o valor do campo txtValorDolar é alterado.
          //alcular();
            
            if (txtValorEmDolar.Text == "")
            {
                cboxValorPossivelConversao.Enabled = false;
                return;
            }
            cboxValorPossivelConversao.Enabled = true;

            EfetuarConversaoMoeda();

        }
        private void cboxValorPossivelConversao_SelectedValueChanged(object sender, EventArgs e)
        {
            // Execulta o método quando o item do combobox é alterado, o professor usou o evento selectIndexChanged.
            // usou o switch(combocox.selectedValue)
            //  case
            //  calcular();
            EfetuarConversaoMoeda();
        }
        private void EfetuarConversaoMoeda()
        {
            try
            {
                if (txtValorEmDolar.Text == "") return;
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var moedasService = new ConverterMoedaService();

                switch (cboxValorPossivelConversao.SelectedValue)
                {
                    case MoedaHelper.Dolar:
                        {
                            var convertido = moedasService.ConverterDolarEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                            lblSegundoValor.Text = $"{convertido}{MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Libras:
                        {
                            var convertido = moedasService.ConverterLibrasEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libras} igual a";
                            lblSegundoValor.Text = $"{convertido}{MoedaHelper.Real}";

                            break;
                        }
                    case MoedaHelper.Euro:
                        {
                            var convertido = moedasService.ConverterEuroEmReal(valorEmDolar);
                            lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                            lblSegundoValor.Text = $"{convertido}{MoedaHelper.Real}";
                            break;
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar o valor numérico");
                txtValorEmDolar.Text = String.Empty;
                txtValorEmDolar.Focus();
            }
            
                    
            

            //private void calcular() //Implementa a programação dos cálculos para posteriormente se acionado nos eventos.
            //{


            #region Meu Programa
            /* try
            {
                if (txtValorEmDolar.Text == "") return;

                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var moeda = new ConverterMoedaService();

                if (cboxValorPossivelConversao.SelectedIndex == 0)
                {

                    var resultado = moeda.ConverterDolarEmReal(valorEmDolar);
                    lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                    lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";
                }
                else if (cboxValorPossivelConversao.SelectedIndex == 1)
                {

                    var resultado = moeda.ConverterLibrasEmReal(valorEmDolar);
                    lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Libras} igual a";
                    lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";
                }
                else if (cboxValorPossivelConversao.SelectedIndex == 2)
                {
                    var resultado = moeda.ConverterEuroEmReal(valorEmDolar);
                    lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Euro} igual a";
                    lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dólar é um valor decimal");
                txtValorEmDolar.Focus();

            }*/
            #endregion
        }
        
    }
}
