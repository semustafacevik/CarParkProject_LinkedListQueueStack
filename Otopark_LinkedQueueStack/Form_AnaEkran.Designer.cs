namespace Otopark_LinkedQueueStack
{
    partial class frmAnaEkran
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstUstKat = new System.Windows.Forms.ListBox();
            this.lstZeminKat = new System.Windows.Forms.ListBox();
            this.lstBodrumKat = new System.Windows.Forms.ListBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.lstCikanBK = new System.Windows.Forms.ListBox();
            this.lstCikanUK = new System.Windows.Forms.ListBox();
            this.lstCikanZK = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtHesaplanan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(24, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 34);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstUstKat
            // 
            this.lstUstKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUstKat.FormattingEnabled = true;
            this.lstUstKat.ItemHeight = 16;
            this.lstUstKat.Location = new System.Drawing.Point(136, 28);
            this.lstUstKat.Name = "lstUstKat";
            this.lstUstKat.Size = new System.Drawing.Size(157, 260);
            this.lstUstKat.TabIndex = 10;
            // 
            // lstZeminKat
            // 
            this.lstZeminKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstZeminKat.FormattingEnabled = true;
            this.lstZeminKat.ItemHeight = 16;
            this.lstZeminKat.Location = new System.Drawing.Point(325, 28);
            this.lstZeminKat.Name = "lstZeminKat";
            this.lstZeminKat.Size = new System.Drawing.Size(157, 260);
            this.lstZeminKat.TabIndex = 11;
            // 
            // lstBodrumKat
            // 
            this.lstBodrumKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBodrumKat.FormattingEnabled = true;
            this.lstBodrumKat.ItemHeight = 16;
            this.lstBodrumKat.Location = new System.Drawing.Point(516, 28);
            this.lstBodrumKat.Name = "lstBodrumKat";
            this.lstBodrumKat.Size = new System.Drawing.Size(157, 260);
            this.lstBodrumKat.TabIndex = 12;
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(24, 74);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(88, 34);
            this.btnCikar.TabIndex = 1;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // lstCikanBK
            // 
            this.lstCikanBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCikanBK.FormattingEnabled = true;
            this.lstCikanBK.ItemHeight = 16;
            this.lstCikanBK.Location = new System.Drawing.Point(516, 319);
            this.lstCikanBK.Name = "lstCikanBK";
            this.lstCikanBK.Size = new System.Drawing.Size(157, 36);
            this.lstCikanBK.TabIndex = 15;
            // 
            // lstCikanUK
            // 
            this.lstCikanUK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCikanUK.FormattingEnabled = true;
            this.lstCikanUK.ItemHeight = 16;
            this.lstCikanUK.Location = new System.Drawing.Point(136, 319);
            this.lstCikanUK.Name = "lstCikanUK";
            this.lstCikanUK.Size = new System.Drawing.Size(157, 36);
            this.lstCikanUK.TabIndex = 13;
            // 
            // lstCikanZK
            // 
            this.lstCikanZK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCikanZK.FormattingEnabled = true;
            this.lstCikanZK.ItemHeight = 16;
            this.lstCikanZK.Location = new System.Drawing.Point(325, 319);
            this.lstCikanZK.Name = "lstCikanZK";
            this.lstCikanZK.Size = new System.Drawing.Size(157, 36);
            this.lstCikanZK.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(177, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÜST KAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(362, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ZEMİN KAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(543, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "BODRUM KAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(353, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "ÇIKAN ARABA";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(24, 120);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(88, 34);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtHesaplanan
            // 
            this.txtHesaplanan.BackColor = System.Drawing.Color.White;
            this.txtHesaplanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHesaplanan.Location = new System.Drawing.Point(24, 170);
            this.txtHesaplanan.Multiline = true;
            this.txtHesaplanan.Name = "txtHesaplanan";
            this.txtHesaplanan.ReadOnly = true;
            this.txtHesaplanan.Size = new System.Drawing.Size(88, 118);
            this.txtHesaplanan.TabIndex = 20;
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 384);
            this.Controls.Add(this.txtHesaplanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCikanZK);
            this.Controls.Add(this.lstCikanBK);
            this.Controls.Add(this.lstBodrumKat);
            this.Controls.Add(this.lstZeminKat);
            this.Controls.Add(this.lstUstKat);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstCikanUK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnaEkran";
            this.Text = "ANA EKRAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstUstKat;
        private System.Windows.Forms.ListBox lstZeminKat;
        private System.Windows.Forms.ListBox lstBodrumKat;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.ListBox lstCikanBK;
        private System.Windows.Forms.ListBox lstCikanUK;
        private System.Windows.Forms.ListBox lstCikanZK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtHesaplanan;
    }
}

