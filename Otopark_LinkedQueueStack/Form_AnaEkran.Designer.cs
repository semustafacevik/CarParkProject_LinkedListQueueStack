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
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(21, 22);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 34);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstUstKat
            // 
            this.lstUstKat.FormattingEnabled = true;
            this.lstUstKat.Location = new System.Drawing.Point(128, 22);
            this.lstUstKat.Name = "lstUstKat";
            this.lstUstKat.Size = new System.Drawing.Size(178, 82);
            this.lstUstKat.TabIndex = 1;
            // 
            // lstZeminKat
            // 
            this.lstZeminKat.FormattingEnabled = true;
            this.lstZeminKat.Location = new System.Drawing.Point(128, 110);
            this.lstZeminKat.Name = "lstZeminKat";
            this.lstZeminKat.Size = new System.Drawing.Size(178, 82);
            this.lstZeminKat.TabIndex = 1;
            // 
            // lstBodrumKat
            // 
            this.lstBodrumKat.FormattingEnabled = true;
            this.lstBodrumKat.Location = new System.Drawing.Point(128, 198);
            this.lstBodrumKat.Name = "lstBodrumKat";
            this.lstBodrumKat.Size = new System.Drawing.Size(178, 82);
            this.lstBodrumKat.TabIndex = 1;
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 372);
            this.Controls.Add(this.lstBodrumKat);
            this.Controls.Add(this.lstZeminKat);
            this.Controls.Add(this.lstUstKat);
            this.Controls.Add(this.btnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnaEkran";
            this.Text = "ANA EKRAN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstUstKat;
        private System.Windows.Forms.ListBox lstZeminKat;
        private System.Windows.Forms.ListBox lstBodrumKat;
    }
}

