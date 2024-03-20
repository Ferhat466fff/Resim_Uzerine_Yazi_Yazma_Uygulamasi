namespace Resim_Üzerine_Yazı_Yazma_Uygulaması
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
            this.btn_Renk_Sec = new System.Windows.Forms.Button();
            this.btn_Resim_Sec = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Yazdir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Metin = new System.Windows.Forms.TextBox();
            this.txt_Boyut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Renk_Sec
            // 
            this.btn_Renk_Sec.Location = new System.Drawing.Point(63, 85);
            this.btn_Renk_Sec.Name = "btn_Renk_Sec";
            this.btn_Renk_Sec.Size = new System.Drawing.Size(289, 43);
            this.btn_Renk_Sec.TabIndex = 0;
            this.btn_Renk_Sec.Text = "Renk Seç";
            this.btn_Renk_Sec.UseVisualStyleBackColor = true;
            this.btn_Renk_Sec.Click += new System.EventHandler(this.btn_Renk_Sec_Click);
            // 
            // btn_Resim_Sec
            // 
            this.btn_Resim_Sec.Location = new System.Drawing.Point(63, 19);
            this.btn_Resim_Sec.Name = "btn_Resim_Sec";
            this.btn_Resim_Sec.Size = new System.Drawing.Size(289, 43);
            this.btn_Resim_Sec.TabIndex = 1;
            this.btn_Resim_Sec.Text = "Resim Seç";
            this.btn_Resim_Sec.UseVisualStyleBackColor = true;
            this.btn_Resim_Sec.Click += new System.EventHandler(this.btn_Resim_Sec_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(63, 217);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(289, 43);
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.Location = new System.Drawing.Point(63, 153);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.Size = new System.Drawing.Size(289, 43);
            this.btn_Yazdir.TabIndex = 2;
            this.btn_Yazdir.Text = "Yazdır";
            this.btn_Yazdir.UseVisualStyleBackColor = true;
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin:";
            // 
            // txt_Metin
            // 
            this.txt_Metin.Location = new System.Drawing.Point(130, 294);
            this.txt_Metin.Name = "txt_Metin";
            this.txt_Metin.Size = new System.Drawing.Size(222, 30);
            this.txt_Metin.TabIndex = 5;
            // 
            // txt_Boyut
            // 
            this.txt_Boyut.Location = new System.Drawing.Point(130, 353);
            this.txt_Boyut.Name = "txt_Boyut";
            this.txt_Boyut.Size = new System.Drawing.Size(222, 30);
            this.txt_Boyut.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boyut:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(387, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_Boyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Metin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Yazdir);
            this.Controls.Add(this.btn_Resim_Sec);
            this.Controls.Add(this.btn_Renk_Sec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Renk_Sec;
        private System.Windows.Forms.Button btn_Resim_Sec;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.Button btn_Yazdir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Metin;
        private System.Windows.Forms.TextBox txt_Boyut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

