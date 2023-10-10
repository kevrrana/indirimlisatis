namespace indirimlisatis
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.chkOgrenci = new System.Windows.Forms.CheckBox();
            this.lblOdenecek = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(137, 86);
            this.txtAdet.Multiline = true;
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(231, 33);
            this.txtAdet.TabIndex = 2;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(137, 130);
            this.txtFiyat.Multiline = true;
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(231, 33);
            this.txtFiyat.TabIndex = 3;
            // 
            // chkOgrenci
            // 
            this.chkOgrenci.AutoSize = true;
            this.chkOgrenci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkOgrenci.Location = new System.Drawing.Point(137, 181);
            this.chkOgrenci.Name = "chkOgrenci";
            this.chkOgrenci.Size = new System.Drawing.Size(231, 28);
            this.chkOgrenci.TabIndex = 4;
            this.chkOgrenci.Text = "Öğrenci (%20 İndirim)";
            this.chkOgrenci.UseVisualStyleBackColor = true;
            // 
            // lblOdenecek
            // 
            this.lblOdenecek.AutoSize = true;
            this.lblOdenecek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecek.Location = new System.Drawing.Point(76, 295);
            this.lblOdenecek.Name = "lblOdenecek";
            this.lblOdenecek.Size = new System.Drawing.Size(201, 25);
            this.lblOdenecek.TabIndex = 5;
            this.lblOdenecek.Text = "Ödenecek Tutar : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(137, 225);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(231, 37);
            this.btnHesapla.TabIndex = 6;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblOdenecek);
            this.Controls.Add(this.chkOgrenci);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.CheckBox chkOgrenci;
        private System.Windows.Forms.Label lblOdenecek;
        private System.Windows.Forms.Button btnHesapla;
    }
}

