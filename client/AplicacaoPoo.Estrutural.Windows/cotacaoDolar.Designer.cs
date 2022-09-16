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
            this.lblCotacaoDolar = new System.Windows.Forms.Label();
            this.lbllerValorDolar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCotacaoDolar
            // 
            this.lblCotacaoDolar.AutoSize = true;
            this.lblCotacaoDolar.Location = new System.Drawing.Point(74, 101);
            this.lblCotacaoDolar.Name = "lblCotacaoDolar";
            this.lblCotacaoDolar.Size = new System.Drawing.Size(98, 15);
            this.lblCotacaoDolar.TabIndex = 0;
            this.lblCotacaoDolar.Text = "Cotação do dólar";
            // 
            // lbllerValorDolar
            // 
            this.lbllerValorDolar.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lbllerValorDolar.AutoSize = true;
            this.lbllerValorDolar.Location = new System.Drawing.Point(90, 144);
            this.lbllerValorDolar.Name = "lbllerValorDolar";
            this.lbllerValorDolar.Size = new System.Drawing.Size(64, 15);
            this.lbllerValorDolar.TabIndex = 1;
            this.lbllerValorDolar.Text = "Valor Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conversor de valor";
            // 
            // frmCotacaoDoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbllerValorDolar);
            this.Controls.Add(this.lblCotacaoDolar);
            this.Name = "frmCotacaoDoDolar";
            this.Text = "frmCotacaoDoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCotacaoDolar;
        private Label lbllerValorDolar;
        private Label label3;
    }
}