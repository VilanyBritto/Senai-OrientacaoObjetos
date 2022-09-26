namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmCotacaoDoDolar
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
            this.lblValorDolar = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.txtValorEmDolar = new System.Windows.Forms.TextBox();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.cboxValorPossivelConversao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(14, 236);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(165, 20);
            this.lblValorDolar.TabIndex = 1;
            this.lblValorDolar.Text = "Informe valor em dólar:";
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoValor.ForeColor = System.Drawing.Color.White;
            this.lblSegundoValor.Location = new System.Drawing.Point(14, 91);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(0, 31);
            this.lblSegundoValor.TabIndex = 10;
            // 
            // txtValorEmDolar
            // 
            this.txtValorEmDolar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValorEmDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorEmDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEmDolar.Location = new System.Drawing.Point(14, 269);
            this.txtValorEmDolar.Name = "txtValorEmDolar";
            this.txtValorEmDolar.PlaceholderText = "valor";
            this.txtValorEmDolar.Size = new System.Drawing.Size(210, 27);
            this.txtValorEmDolar.TabIndex = 1;
            this.txtValorEmDolar.TextChanged += new System.EventHandler(this.txtValorDolar_TextChanged);
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimeiroValor.ForeColor = System.Drawing.Color.White;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(14, 45);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(0, 23);
            this.lblPrimeiroValor.TabIndex = 9;
            // 
            // cboxValorPossivelConversao
            // 
            this.cboxValorPossivelConversao.FormattingEnabled = true;
            this.cboxValorPossivelConversao.Items.AddRange(new object[] {
            "Dolar Americano",
            " Libras Esterlinas",
            " Euro"});
            this.cboxValorPossivelConversao.Location = new System.Drawing.Point(14, 190);
            this.cboxValorPossivelConversao.Name = "cboxValorPossivelConversao";
            this.cboxValorPossivelConversao.Size = new System.Drawing.Size(210, 28);
            this.cboxValorPossivelConversao.TabIndex = 11;
            this.cboxValorPossivelConversao.Text = "[Escolha Moeda]";
            this.cboxValorPossivelConversao.SelectedValueChanged += new System.EventHandler(this.cboxValorPossivelConversao_SelectedValueChanged);
            // 
            // frmCotacaoDoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(477, 349);
            this.Controls.Add(this.cboxValorPossivelConversao);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.txtValorEmDolar);
            this.Controls.Add(this.lblValorDolar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCotacaoDoDolar";
            this.Text = "frmCotacaoDoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblValorDolar;
        internal Label lblSegundoValor;
        private TextBox txtValorEmDolar;
        private Label lblPrimeiroValor;
        private ComboBox cboxValorPossivelConversao;
    }
}