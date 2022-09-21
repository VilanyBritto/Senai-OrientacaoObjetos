namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmPrincipal
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
            this.btnCotacaoDoDolar = new System.Windows.Forms.Button();
            this.btnControleVendedorComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCotacaoDoDolar
            // 
            this.btnCotacaoDoDolar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCotacaoDoDolar.Location = new System.Drawing.Point(55, 77);
            this.btnCotacaoDoDolar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCotacaoDoDolar.Name = "btnCotacaoDoDolar";
            this.btnCotacaoDoDolar.Size = new System.Drawing.Size(133, 31);
            this.btnCotacaoDoDolar.TabIndex = 0;
            this.btnCotacaoDoDolar.Text = "Cotação do dólar";
            this.btnCotacaoDoDolar.UseVisualStyleBackColor = false;
            this.btnCotacaoDoDolar.Click += new System.EventHandler(this.cotacaoDoDolar);
            // 
            // btnControleVendedorComissao
            // 
            this.btnControleVendedorComissao.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnControleVendedorComissao.Location = new System.Drawing.Point(246, 77);
            this.btnControleVendedorComissao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnControleVendedorComissao.Name = "btnControleVendedorComissao";
            this.btnControleVendedorComissao.Size = new System.Drawing.Size(189, 31);
            this.btnControleVendedorComissao.TabIndex = 1;
            this.btnControleVendedorComissao.Text = "Comissão vendedor";
            this.btnControleVendedorComissao.UseVisualStyleBackColor = false;
            this.btnControleVendedorComissao.Click += new System.EventHandler(this.btnControleVendedor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 181);
            this.Controls.Add(this.btnControleVendedorComissao);
            this.Controls.Add(this.btnCotacaoDoDolar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCotacaoDoDolar;
        private Button btnControleVendedorComissao;
    }
}