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
            this.lstUstKat.Size = new System.Drawing.Size(178, 212);
            this.lstUstKat.TabIndex = 1;
            // 
            // lstZeminKat
            // 
            this.lstZeminKat.FormattingEnabled = true;
            this.lstZeminKat.Location = new System.Drawing.Point(328, 22);
            this.lstZeminKat.Name = "lstZeminKat";
            this.lstZeminKat.Size = new System.Drawing.Size(178, 212);
            this.lstZeminKat.TabIndex = 1;
            // 
            // lstBodrumKat
            // 
            this.lstBodrumKat.FormattingEnabled = true;
            this.lstBodrumKat.Location = new System.Drawing.Point(532, 22);
            this.lstBodrumKat.Name = "lstBodrumKat";
            this.lstBodrumKat.Size = new System.Drawing.Size(178, 212);
            this.lstBodrumKat.TabIndex = 1;
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(21, 70);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(88, 34);
            this.btnCikar.TabIndex = 0;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // lstCikanBK
            // 
            this.lstCikanBK.FormattingEnabled = true;
            this.lstCikanBK.Location = new System.Drawing.Point(532, 253);
            this.lstCikanBK.Name = "lstCikanBK";
            this.lstCikanBK.Size = new System.Drawing.Size(178, 43);
            this.lstCikanBK.TabIndex = 1;
            // 
            // lstCikanUK
            // 
            this.lstCikanUK.FormattingEnabled = true;
            this.lstCikanUK.Location = new System.Drawing.Point(128, 253);
            this.lstCikanUK.Name = "lstCikanUK";
            this.lstCikanUK.Size = new System.Drawing.Size(178, 43);
            this.lstCikanUK.TabIndex = 1;
            // 
            // lstCikanZK
            // 
            this.lstCikanZK.FormattingEnabled = true;
            this.lstCikanZK.Location = new System.Drawing.Point(328, 253);
            this.lstCikanZK.Name = "lstCikanZK";
            this.lstCikanZK.Size = new System.Drawing.Size(178, 43);
            this.lstCikanZK.TabIndex = 1;
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 372);
            this.Controls.Add(this.lstCikanZK);
            this.Controls.Add(this.lstCikanUK);
            this.Controls.Add(this.lstCikanBK);
            this.Controls.Add(this.lstBodrumKat);
            this.Controls.Add(this.lstZeminKat);
            this.Controls.Add(this.lstUstKat);
            this.Controls.Add(this.btnCikar);
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
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.ListBox lstCikanBK;
        private System.Windows.Forms.ListBox lstCikanUK;
        private System.Windows.Forms.ListBox lstCikanZK;
    }
}

