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
            this.btnControleVendedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCotacaoDoDolar
            // 
            this.btnCotacaoDoDolar.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCotacaoDoDolar.Location = new System.Drawing.Point(48, 58);
            this.btnCotacaoDoDolar.Name = "btnCotacaoDoDolar";
            this.btnCotacaoDoDolar.Size = new System.Drawing.Size(116, 23);
            this.btnCotacaoDoDolar.TabIndex = 0;
            this.btnCotacaoDoDolar.Text = "Cotação do dólar";
            this.btnCotacaoDoDolar.UseVisualStyleBackColor = false;
            this.btnCotacaoDoDolar.Click += new System.EventHandler(this.cotacaoDoDolar);
            // 
            // btnControleVendedor
            // 
            this.btnControleVendedor.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnControleVendedor.Location = new System.Drawing.Point(215, 58);
            this.btnControleVendedor.Name = "btnControleVendedor";
            this.btnControleVendedor.Size = new System.Drawing.Size(120, 23);
            this.btnControleVendedor.TabIndex = 1;
            this.btnControleVendedor.Text = "Controle Vendedor";
            this.btnControleVendedor.UseVisualStyleBackColor = false;
            this.btnControleVendedor.Click += new System.EventHandler(this.btnControleVendedor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 136);
            this.Controls.Add(this.btnControleVendedor);
            this.Controls.Add(this.btnCotacaoDoDolar);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCotacaoDoDolar;
        private Button btnControleVendedor;
    }
}