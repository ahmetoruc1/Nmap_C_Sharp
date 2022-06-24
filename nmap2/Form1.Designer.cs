
namespace nmap2
{
    partial class Form1
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxHOST = new System.Windows.Forms.TextBox();
            this.buttonoku = new System.Windows.Forms.Button();
            this.buttonDUR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(80, 37);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 22);
            this.textBoxIP.TabIndex = 0;
            // 
            // textBoxHOST
            // 
            this.textBoxHOST.Location = new System.Drawing.Point(52, 92);
            this.textBoxHOST.Multiline = true;
            this.textBoxHOST.Name = "textBoxHOST";
            this.textBoxHOST.Size = new System.Drawing.Size(378, 197);
            this.textBoxHOST.TabIndex = 0;
            // 
            // buttonoku
            // 
            this.buttonoku.Location = new System.Drawing.Point(196, 31);
            this.buttonoku.Name = "buttonoku";
            this.buttonoku.Size = new System.Drawing.Size(93, 35);
            this.buttonoku.TabIndex = 1;
            this.buttonoku.Text = "OKU";
            this.buttonoku.UseVisualStyleBackColor = true;
            this.buttonoku.Click += new System.EventHandler(this.buttonoku_Click);
            // 
            // buttonDUR
            // 
            this.buttonDUR.Location = new System.Drawing.Point(295, 31);
            this.buttonDUR.Name = "buttonDUR";
            this.buttonDUR.Size = new System.Drawing.Size(91, 35);
            this.buttonDUR.TabIndex = 1;
            this.buttonDUR.Text = "DUR";
            this.buttonDUR.UseVisualStyleBackColor = true;
            this.buttonDUR.Click += new System.EventHandler(this.buttonDUR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 350);
            this.Controls.Add(this.buttonDUR);
            this.Controls.Add(this.buttonoku);
            this.Controls.Add(this.textBoxHOST);
            this.Controls.Add(this.textBoxIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxHOST;
        private System.Windows.Forms.Button buttonoku;
        private System.Windows.Forms.Button buttonDUR;
    }
}

