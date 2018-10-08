using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.DefaultExt = ".jpg"; openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(ResminYolu);
            }


        }
        Bitmap islem;
        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            ImageFormat format = ImageFormat.Png;
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griYap(Image);
            pictureBox2.Image = gri;

        }
        private Bitmap griYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R * 0.299 + bmp.GetPixel(j, i).G * 0.587 + bmp.GetPixel(j, i).B * 0.114);
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;


        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = griyap(Image);
            pictureBox2.Image = gri;

        }
        private Bitmap griyap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;

        }

        private void bt709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = grıyaap(Image);
            pictureBox2.Image = gri;

        }
        private Bitmap grıyaap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R * 0.2125 + bmp.GetPixel(j, i).G * 0.7154 + bmp.GetPixel(j, i).B * 0.072);
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;


        }

        private void kanalÇıkarımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBox1.Image);
            Bitmap gri = grıYaap(Image);
            pictureBox2.Image = gri;

        }
        private Bitmap grıYaap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = Convert.ToInt16(bmp.GetPixel(j, i).R * 0 + bmp.GetPixel(j, i).G * 0 + bmp.GetPixel(j, i).B * 0);
                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);
                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
