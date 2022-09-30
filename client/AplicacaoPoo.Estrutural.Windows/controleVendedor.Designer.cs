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
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInformacoesDoPedido = new System.Windows.Forms.Label();
            this.cboNomeVendedor = new System.Windows.Forms.ComboBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(99, 21);
            this.cboProduto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(314, 28);
            this.cboProduto.TabIndex = 9;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(34, 172);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(85, 27);
            this.txtQuantidade.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome Vendedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.lblDescricaoProduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.cboProduto);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(31, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(419, 228);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(272, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Informações do pedido:";
            // 
            // lblInformacoesDoPedido
            // 
            this.lblInformacoesDoPedido.BackColor = System.Drawing.Color.Lavender;
            this.lblInformacoesDoPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInformacoesDoPedido.Location = new System.Drawing.Point(25, 384);
            this.lblInformacoesDoPedido.Name = "lblInformacoesDoPedido";
            this.lblInformacoesDoPedido.Size = new System.Drawing.Size(419, 109);
            this.lblInformacoesDoPedido.TabIndex = 15;
            // 
            // cboNomeVendedor
            // 
            this.cboNomeVendedor.FormattingEnabled = true;
            this.cboNomeVendedor.Location = new System.Drawing.Point(177, 21);
            this.cboNomeVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNomeVendedor.Name = "cboNomeVendedor";
            this.cboNomeVendedor.Size = new System.Drawing.Size(273, 28);
            this.cboNomeVendedor.TabIndex = 12;
            this.cboNomeVendedor.SelectedIndexChanged += new System.EventHandler(this.cboNomeVendedor_SelectedIndexChanged);
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.BackColor = System.Drawing.Color.Lavender;
            this.lblDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(7, 53);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(406, 81);
            this.lblDescricaoProduto.TabIndex = 12;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.LightGreen;
            this.lblValorTotal.Location = new System.Drawing.Point(238, 169);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(175, 45);
            this.lblValorTotal.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.Snow;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrar.Location = new System.Drawing.Point(315, 305);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 30);
            this.btnRegistrar.TabIndex = 16;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // frmControleComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(458, 523);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboNomeVendedor);
            this.Controls.Add(this.lblInformacoesDoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmControleComissao";
            this.Text = "frmcontroleComissao";
            this.Load += new System.EventHandler(this.frmControleComissao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cboProduto;
        private TextBox txtQuantidade;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label lblInformacoesDoPedido;
        private ComboBox cboNomeVendedor;
        private Label label8;
        private Label lblValorTotal;
        private Label lblDescricaoProduto;
        private Button btnRegistrar;
    }
}