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
            this.lblMostarResultado = new System.Windows.Forms.Label();
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.btnCalcularResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(65, 98);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(131, 15);
            this.lblValorDolar.TabIndex = 1;
            this.lblValorDolar.Text = "Informe valor em dólar:";
            // 
            // lblMostarResultado
            // 
            this.lblMostarResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMostarResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostarResultado.Location = new System.Drawing.Point(42, 183);
            this.lblMostarResultado.Name = "lblMostarResultado";
            this.lblMostarResultado.Size = new System.Drawing.Size(244, 31);
            this.lblMostarResultado.TabIndex = 3;
            this.lblMostarResultado.Text = "Descrição do resultado:";
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Location = new System.Drawing.Point(200, 93);
            this.txtValorDolar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.Size = new System.Drawing.Size(88, 23);
            this.txtValorDolar.TabIndex = 1;
            this.txtValorDolar.TextChanged += new System.EventHandler(this.txtValorDolar_TextChanged);
            this.txtValorDolar.Leave += new System.EventHandler(this.txtValorDolar_Leave);
            // 
            // btnCalcularResultado
            // 
            this.btnCalcularResultado.Location = new System.Drawing.Point(200, 147);
            this.btnCalcularResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcularResultado.Name = "btnCalcularResultado";
            this.btnCalcularResultado.Size = new System.Drawing.Size(88, 24);
            this.btnCalcularResultado.TabIndex = 8;
            this.btnCalcularResultado.Text = "Calcular";
            this.btnCalcularResultado.UseVisualStyleBackColor = true;
            this.btnCalcularResultado.Click += new System.EventHandler(this.btnCalcularResultado_Click);
            // 
            // frmCotacaoDoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 236);
            this.Controls.Add(this.btnCalcularResultado);
            this.Controls.Add(this.txtValorDolar);
            this.Controls.Add(this.lblMostarResultado);
            this.Controls.Add(this.lblValorDolar);
            this.Name = "frmCotacaoDoDolar";
            this.Text = "frmCotacaoDoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblValorDolar;
        private Label lblMostarResultado;
        private TextBox txtValorDolar;
        private Button btnCalcularResultado;
    }
}