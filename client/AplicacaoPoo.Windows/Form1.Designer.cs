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
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(164, 85);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 23);
            this.textNome.TabIndex = 0;
            // 
            // textCredito
            // 
            this.textCredito.Location = new System.Drawing.Point(164, 231);
            this.textCredito.Name = "textCredito";
            this.textCredito.Size = new System.Drawing.Size(100, 23);
            this.textCredito.TabIndex = 1;
            // 
            // textDebito
            // 
            this.textDebito.Location = new System.Drawing.Point(164, 186);
            this.textDebito.Name = "textDebito";
            this.textDebito.Size = new System.Drawing.Size(100, 23);
            this.textDebito.TabIndex = 2;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(164, 135);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(100, 23);
            this.textCpf.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(96, 88);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblValorDeCredito
            // 
            this.lblValorDeCredito.AutoSize = true;
            this.lblValorDeCredito.Location = new System.Drawing.Point(96, 239);
            this.lblValorDeCredito.Name = "lblValorDeCredito";
            this.lblValorDeCredito.Size = new System.Drawing.Size(46, 15);
            this.lblValorDeCredito.TabIndex = 5;
            this.lblValorDeCredito.Text = "Crédito";
            // 
            // lblValorDeDebito
            // 
            this.lblValorDeDebito.AutoSize = true;
            this.lblValorDeDebito.Location = new System.Drawing.Point(96, 194);
            this.lblValorDeDebito.Name = "lblValorDeDebito";
            this.lblValorDeDebito.Size = new System.Drawing.Size(42, 15);
            this.lblValorDeDebito.TabIndex = 6;
            this.lblValorDeDebito.Text = "Débito";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(96, 135);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(28, 15);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}