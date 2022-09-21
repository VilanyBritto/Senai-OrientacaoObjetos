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
            this.lblValorDolar = new System.Windows.Forms.Label();
            this.lblConversorDolar = new System.Windows.Forms.Label();
            this.lblMostarResultado = new System.Windows.Forms.Label();
            this.txtConversor = new System.Windows.Forms.TextBox();
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.btnCalcularResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCotacaoDolar
            // 
            this.lblCotacaoDolar.AutoSize = true;
            this.lblCotacaoDolar.Location = new System.Drawing.Point(48, 96);
            this.lblCotacaoDolar.Name = "lblCotacaoDolar";
            this.lblCotacaoDolar.Size = new System.Drawing.Size(157, 15);
            this.lblCotacaoDolar.TabIndex = 0;
            this.lblCotacaoDolar.Text = "Informe valor  do dólar hoje:";
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(74, 130);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(131, 15);
            this.lblValorDolar.TabIndex = 1;
            this.lblValorDolar.Text = "Informe valor em dólar:";
            // 
            // lblConversorDolar
            // 
            this.lblConversorDolar.AutoSize = true;
            this.lblConversorDolar.Location = new System.Drawing.Point(99, 162);
            this.lblConversorDolar.Name = "lblConversorDolar";
            this.lblConversorDolar.Size = new System.Drawing.Size(100, 15);
            this.lblConversorDolar.TabIndex = 2;
            this.lblConversorDolar.Text = "Conversor em R$:";
            // 
            // lblMostarResultado
            // 
            this.lblMostarResultado.BackColor = System.Drawing.Color.Gainsboro;
            this.lblMostarResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostarResultado.Location = new System.Drawing.Point(48, 221);
            this.lblMostarResultado.Name = "lblMostarResultado";
            this.lblMostarResultado.Size = new System.Drawing.Size(279, 41);
            this.lblMostarResultado.TabIndex = 3;
            this.lblMostarResultado.Text = "Descrição do resultado:";
            // 
            // txtConversor
            // 
            this.txtConversor.Location = new System.Drawing.Point(228, 160);
            this.txtConversor.Name = "txtConversor";
            this.txtConversor.Size = new System.Drawing.Size(100, 23);
            this.txtConversor.TabIndex = 2;
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Location = new System.Drawing.Point(228, 124);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.Size = new System.Drawing.Size(100, 23);
            this.txtValorDolar.TabIndex = 1;
            this.txtValorDolar.TextChanged += new System.EventHandler(this.txtValorDolar_TextChanged);
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.Location = new System.Drawing.Point(228, 91);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(100, 23);
            this.txtCotacaoDolar.TabIndex = 0;
            this.txtCotacaoDolar.TextChanged += new System.EventHandler(this.txtCotacaoDolar_TextChanged);
            // 
            // btnCalcularResultado
            // 
            this.btnCalcularResultado.Location = new System.Drawing.Point(245, 197);
            this.btnCalcularResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcularResultado.Name = "btnCalcularResultado";
            this.btnCalcularResultado.Size = new System.Drawing.Size(82, 22);
            this.btnCalcularResultado.TabIndex = 8;
            this.btnCalcularResultado.Text = "Calcular";
            this.btnCalcularResultado.UseVisualStyleBackColor = true;
            this.btnCalcularResultado.Click += new System.EventHandler(this.btnCalcularResultado_Click);
            // 
            // frmCotacaoDoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 279);
            this.Controls.Add(this.btnCalcularResultado);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Controls.Add(this.txtValorDolar);
            this.Controls.Add(this.txtConversor);
            this.Controls.Add(this.lblMostarResultado);
            this.Controls.Add(this.lblConversorDolar);
            this.Controls.Add(this.lblValorDolar);
            this.Controls.Add(this.lblCotacaoDolar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCotacaoDoDolar";
            this.Text = "frmCotacaoDoDolar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCotacaoDolar;
        private Label lblValorDolar;
        private Label lblConversorDolar;
        private Label lblMostarResultado;
        private TextBox txtConversor;
        private TextBox txtValorDolar;
        private TextBox txtCotacaoDolar;
        private Button btnCalcularResultado;
    }
}