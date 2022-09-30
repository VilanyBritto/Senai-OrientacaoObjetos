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
            this.lblCodigoPeca = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.gBoxPedido = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gBoxPedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(5, 59);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(85, 15);
            this.lblPrecoUnitario.TabIndex = 4;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // gBoxPedido
            // 
            this.gBoxPedido.Controls.Add(this.lblQuantidade);
            this.gBoxPedido.Controls.Add(this.lblCodigoPeca);
            this.gBoxPedido.Controls.Add(this.lblPrecoUnitario);
            this.gBoxPedido.Location = new System.Drawing.Point(51, 104);
            this.gBoxPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxPedido.Name = "gBoxPedido";
            this.gBoxPedido.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBoxPedido.Size = new System.Drawing.Size(326, 135);
            this.gBoxPedido.TabIndex = 6;
            this.gBoxPedido.TabStop = false;
            this.gBoxPedido.Text = "Pedido:";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 23);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(455, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome Vendedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(455, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 95);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(455, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Informações do pedido:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(455, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 77);
            this.label5.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(562, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 23);
            this.comboBox2.TabIndex = 12;
            // 
            // frmControleComissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(813, 399);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblDescrição);
            this.Controls.Add(this.gBoxPedido);
            this.Name = "frmControleComissao";
            this.Text = "frmcontroleComissao";
            this.Load += new System.EventHandler(this.frmControleComissao_Load);
            this.gBoxPedido.ResumeLayout(false);
            this.gBoxPedido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
    }
}