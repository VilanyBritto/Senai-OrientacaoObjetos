namespace AplicacaoPoo.Estrutural.Windows
{
    partial class frmStatic
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
            this.components = new System.ComponentModel.Container();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(12, 184);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(485, 23);
            this.progressBarLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarLoading.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacaoPoo.Estrutural.Windows.Properties.Resources.logomarca_oficial_SENAI1;
            this.pictureBox1.Location = new System.Drawing.Point(95, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 131);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 257);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBarLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStatic";
            this.Text = "frmStatic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerLoading;
        private ProgressBar progressBarLoading;
        private PictureBox pictureBox1;
    }
}