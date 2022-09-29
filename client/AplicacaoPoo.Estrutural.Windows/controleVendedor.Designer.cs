namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmControleComissao
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
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.txtCodigoDaPeca = new System.Windows.Forms.TextBox();
            this.gBoxPedido = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gBoxPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeVendedor.Location = new System.Drawing.Point(51, 75);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(101, 15);
            this.lblNomeVendedor.TabIndex = 0;
            this.lblNomeVendedor.Text = "Nome Vendedor:";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(162, 73);
            this.txtNomeVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(216, 23);
            this.txtNomeVendedor.TabIndex = 0;
            // 
            // lblCodigoPeca
            // 
            this.lblCodigoPeca.AutoSize = true;
            this.lblCodigoPeca.Location = new System.Drawing.Point(5, 29);
            this.lblCodigoPeca.Name = "lblCodigoPeca";
            this.lblCodigoPeca.Size = new System.Drawing.Size(93, 15);
            this.lblCodigoPeca.TabIndex = 2;
            this.lblCodigoPeca.Text = "Código da peça:";
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(132, 59);
            this.txtPrecoUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(110, 23);
            this.txtPrecoUnitario.TabIndex = 2;
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(5, 59);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(85, 15);
            this.lblPrecoUnitario.TabIndex = 4;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // txtCodigoDaPeca
            // 
            this.txtCodigoDaPeca.Location = new System.Drawing.Point(132, 27);
            this.txtCodigoDaPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoDaPeca.Name = "txtCodigoDaPeca";
            this.txtCodigoDaPeca.Size = new System.Drawing.Size(110, 23);
            this.txtCodigoDaPeca.TabIndex = 1;
            // 
            // gBoxPedido
            // 
            this.gBoxPedido.Controls.Add(this.txtQuantidade);
            this.gBoxPedido.Controls.Add(this.lblQuantidade);
            this.gBoxPedido.Controls.Add(this.lblCodigoPeca);
            this.gBoxPedido.Controls.Add(this.txtPrecoUnitario);
            this.gBoxPedido.Controls.Add(this.lblPrecoUnitario);
            this.gBoxPedido.Controls.Add(this.txtCodigoDaPeca);
            this.gBoxPedido.Location = new System.Drawing.Point(51, 104);
            this.gBoxPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxPedido.Name = "gBoxPedido";
            this.gBoxPedido.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxPedido.Size = new System.Drawing.Size(326, 135);
            this.gBoxPedido.TabIndex = 6;
            this.gBoxPedido.TabStop = false;
            this.gBoxPedido.Text = "Pedido:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(132, 91);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(110, 23);
            this.txtQuantidade.TabIndex = 3;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(5, 91);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(72, 15);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescrição.Location = new System.Drawing.Point(51, 284);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(88, 21);
            this.lblDescrição.TabIndex = 7;
            this.lblDescrição.Text = "Descrição:";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.Color.Lavender;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Location = new System.Drawing.Point(51, 305);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(326, 76);
            this.lblResultado.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(284, 254);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(82, 25);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmControleComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(436, 399);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDescrição);
            this.Controls.Add(this.gBoxPedido);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.lblNomeVendedor);
            this.Name = "frmControleComissao";
            this.Text = "frmcontroleComissao";
            this.gBoxPedido.ResumeLayout(false);
            this.gBoxPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeVendedor;
        private TextBox txtNomeVendedor;
        private Label lblCodigoPeca;
        private TextBox txtPrecoUnitario;
        private Label lblPrecoUnitario;
        private TextBox txtCodigoDaPeca;
        private GroupBox gBoxPedido;
        private TextBox txtQuantidade;
        private Label lblQuantidade;
        private Label lblDescrição;
        private Label lblResultado;
        private Button btnCalcular;
    }
}