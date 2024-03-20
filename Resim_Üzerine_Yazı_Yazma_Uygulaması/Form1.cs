using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resim_Üzerine_Yazı_Yazma_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resim;
        private void btn_Resim_Sec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;//resim değişkeni openfiledialogdan secilen resim olacak

        }

        Color renk;
        private void btn_Renk_Sec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;//renk değişkeni colordialog secilen renk olacak
        }
        Bitmap bmp;//üzerinde değişiklik yapacağımız dosyalar için sınıf.
        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
//değişiklik yapacağımız dosya=Resim(openfilediaolog secilecek olan şey yukarda yaptıgımız )olmuş oldu
            Graphics gr = Graphics.FromImage(bmp);//grafiği bmp üzerine işle
            gr.DrawString(txt_Metin.Text, new Font("Segoe UI", Convert.ToInt16(txt_Boyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
//gr.üzerine çiz(1-->üzerine ne yazacaksın(txt metin)
//2-->yazının font-boyut-kalınlığı belirleniyor
//3-->Renk(solid brush )kullanman gerek
//4-->soldan uzaklık, yukardan uzaklık
            pictureBox1.Image = bmp;//bmp(yukarda yapılanları pictureboxa yap)



        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "MARABA|.jpg";//jpg formatıda kaydeildecek
            saveFileDialog1.ShowDialog();//aç
            bmp.Save(saveFileDialog1.FileName);//bmp'yi kaydet(save file dialoga girecegimiz ismiyle)
            MessageBox.Show("Resim Masaüstüne Kaydedildi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
