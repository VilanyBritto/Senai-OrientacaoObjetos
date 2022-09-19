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
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtConversor = new System.Windows.Forms.TextBox();
            this.txtValorDolar = new System.Windows.Forms.TextBox();
            this.txtCotacaoDolar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCotacaoDolar
            // 
            this.lblCotacaoDolar.AutoSize = true;
            this.lblCotacaoDolar.Location = new System.Drawing.Point(55, 128);
            this.lblCotacaoDolar.Name = "lblCotacaoDolar";
            this.lblCotacaoDolar.Size = new System.Drawing.Size(199, 20);
            this.lblCotacaoDolar.TabIndex = 0;
            this.lblCotacaoDolar.Text = "Informe valor  do dólar hoje:";
            // 
            // lblValorDolar
            // 
            this.lblValorDolar.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.lblValorDolar.AutoSize = true;
            this.lblValorDolar.Location = new System.Drawing.Point(85, 173);
            this.lblValorDolar.Name = "lblValorDolar";
            this.lblValorDolar.Size = new System.Drawing.Size(165, 20);
            this.lblValorDolar.TabIndex = 1;
            this.lblValorDolar.Text = "Informe valor em dólar:";
            // 
            // lblConversorDolar
            // 
            this.lblConversorDolar.AutoSize = true;
            this.lblConversorDolar.Location = new System.Drawing.Point(113, 216);
            this.lblConversorDolar.Name = "lblConversorDolar";
            this.lblConversorDolar.Size = new System.Drawing.Size(133, 20);
            this.lblConversorDolar.TabIndex = 2;
            this.lblConversorDolar.Text = "Conversor para R$:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(163, 272);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtConversor
            // 
            this.txtConversor.Location = new System.Drawing.Point(241, 212);
            this.txtConversor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConversor.Name = "txtConversor";
            this.txtConversor.Size = new System.Drawing.Size(114, 27);
            this.txtConversor.TabIndex = 5;
            // 
            // txtValorDolar
            // 
            this.txtValorDolar.Location = new System.Drawing.Point(241, 163);
            this.txtValorDolar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorDolar.Name = "txtValorDolar";
            this.txtValorDolar.Size = new System.Drawing.Size(114, 27);
            this.txtValorDolar.TabIndex = 6;
            this.txtValorDolar.Leave += new System.EventHandler(this.txtValorDolar_Leave);
            // 
            // txtCotacaoDolar
            // 
            this.txtCotacaoDolar.Location = new System.Drawing.Point(241, 117);
            this.txtCotacaoDolar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCotacaoDolar.Name = "txtCotacaoDolar";
            this.txtCotacaoDolar.Size = new System.Drawing.Size(114, 27);
            this.txtCotacaoDolar.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(261, 309);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "button1";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCotacaoDoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 372);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCotacaoDolar);
            this.Controls.Add(this.txtValorDolar);
            this.Controls.Add(this.txtConversor);
            this.Controls.Add(this.lblResultado);
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
        private Label lblResultado;
        private TextBox txtConversor;
        private TextBox txtValorDolar;
        private TextBox txtCotacaoDolar;
        private Button btnCalcular;
    }
}