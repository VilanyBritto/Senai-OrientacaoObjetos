namespace AplicacaoPoo.Windows
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCredito = new System.Windows.Forms.TextBox();
            this.textDebito = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValorDeCredito = new System.Windows.Forms.Label();
            this.lblValorDeDebito = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSaldoInicial = new System.Windows.Forms.Label();
            this.lblSaldoInicialValor = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(75, 77);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(237, 23);
            this.textNome.TabIndex = 0;
            // 
            // textCredito
            // 
            this.textCredito.Location = new System.Drawing.Point(75, 135);
            this.textCredito.Name = "textCredito";
            this.textCredito.Size = new System.Drawing.Size(141, 23);
            this.textCredito.TabIndex = 1;
            // 
            // textDebito
            // 
            this.textDebito.Location = new System.Drawing.Point(75, 106);
            this.textDebito.Name = "textDebito";
            this.textDebito.Size = new System.Drawing.Size(141, 23);
            this.textDebito.TabIndex = 2;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(352, 77);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(165, 23);
            this.textCpf.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblValorDeCredito
            // 
            this.lblValorDeCredito.AutoSize = true;
            this.lblValorDeCredito.Location = new System.Drawing.Point(23, 143);
            this.lblValorDeCredito.Name = "lblValorDeCredito";
            this.lblValorDeCredito.Size = new System.Drawing.Size(49, 15);
            this.lblValorDeCredito.TabIndex = 5;
            this.lblValorDeCredito.Text = "Crédito:";
            // 
            // lblValorDeDebito
            // 
            this.lblValorDeDebito.AutoSize = true;
            this.lblValorDeDebito.Location = new System.Drawing.Point(23, 114);
            this.lblValorDeDebito.Name = "lblValorDeDebito";
            this.lblValorDeDebito.Size = new System.Drawing.Size(45, 15);
            this.lblValorDeDebito.TabIndex = 6;
            this.lblValorDeDebito.Text = "Débito:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(318, 85);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(31, 15);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(75, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSaldoInicial
            // 
            this.lblSaldoInicial.AutoSize = true;
            this.lblSaldoInicial.Location = new System.Drawing.Point(534, 85);
            this.lblSaldoInicial.Name = "lblSaldoInicial";
            this.lblSaldoInicial.Size = new System.Drawing.Size(70, 15);
            this.lblSaldoInicial.TabIndex = 9;
            this.lblSaldoInicial.Text = "Saldo inicial";
            // 
            // lblSaldoInicialValor
            // 
            this.lblSaldoInicialValor.AutoSize = true;
            this.lblSaldoInicialValor.Location = new System.Drawing.Point(534, 109);
            this.lblSaldoInicialValor.Name = "lblSaldoInicialValor";
            this.lblSaldoInicialValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoInicialValor.TabIndex = 10;
            this.lblSaldoInicialValor.Text = "0";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(534, 135);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(36, 15);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblSaldoValor
            // 
            this.lblSaldoValor.AutoSize = true;
            this.lblSaldoValor.Location = new System.Drawing.Point(534, 165);
            this.lblSaldoValor.Name = "lblSaldoValor";
            this.lblSaldoValor.Size = new System.Drawing.Size(13, 15);
            this.lblSaldoValor.TabIndex = 12;
            this.lblSaldoValor.Text = "0";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 262);
            this.Controls.Add(this.lblSaldoValor);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblSaldoInicialValor);
            this.Controls.Add(this.lblSaldoInicial);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblValorDeDebito);
            this.Controls.Add(this.lblValorDeCredito);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textDebito);
            this.Controls.Add(this.textCredito);
            this.Controls.Add(this.textNome);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textNome;
        private TextBox textCredito;
        private TextBox textDebito;
        private TextBox textCpf;
        private Label lblNome;
        private Label lblValorDeCredito;
        private Label lblValorDeDebito;
        private Label lblCpf;
        private Button btnCalcular;
        private Label lblSaldoInicial;
        private Label lblSaldoInicialValor;
        private Label lblSaldo;
        private Label lblSaldoValor;
    }
}