namespace Tc_Kimlik_Maskeleme
{
    partial class TcMaskeleme
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblMaskelenmis = new System.Windows.Forms.Label();
            this.btnMaskele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(75, 22);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 0;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // lblMaskelenmis
            // 
            this.lblMaskelenmis.AutoSize = true;
            this.lblMaskelenmis.Location = new System.Drawing.Point(103, 93);
            this.lblMaskelenmis.Name = "lblMaskelenmis";
            this.lblMaskelenmis.Size = new System.Drawing.Size(0, 13);
            this.lblMaskelenmis.TabIndex = 1;
            // 
            // btnMaskele
            // 
            this.btnMaskele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaskele.Location = new System.Drawing.Point(85, 48);
            this.btnMaskele.Name = "btnMaskele";
            this.btnMaskele.Size = new System.Drawing.Size(75, 23);
            this.btnMaskele.TabIndex = 2;
            this.btnMaskele.Text = "Maskele";
            this.btnMaskele.UseVisualStyleBackColor = true;
            this.btnMaskele.Click += new System.EventHandler(this.btnMaskele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Maskelenmiş TC: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TcMaskeleme
            // 
            this.AcceptButton = this.btnMaskele;
            this.ClientSize = new System.Drawing.Size(226, 141);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMaskele);
            this.Controls.Add(this.lblMaskelenmis);
            this.Controls.Add(this.txtTc);
            this.Name = "TcMaskeleme";
            this.Load += new System.EventHandler(this.TcMaskeleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblMaskelenmis;
        private System.Windows.Forms.Button btnMaskele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

