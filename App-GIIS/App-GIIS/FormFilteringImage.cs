using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace App_GIIS
{
    public partial class FormFilteringImage : Form
    {
        public FormFilteringImage()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxDropAndDrag_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pictureBoxDropAndDrag.Image = Image.FromFile(fileNames[0]);
                    pictureBox1.Image = pictureBoxDropAndDrag.Image;
                    pictureBox2.Image = pictureBoxDropAndDrag.Image;
                    pictureBox3.Image = pictureBoxDropAndDrag.Image;
                    labelWidth.Text = pictureBox3.Image.Width.ToString();
                    labelHeight.Text = pictureBox3.Image.Height.ToString();
                }
            }
        }

        private void FormFilteringImage_Load(object sender, EventArgs e)
        {
            pictureBoxDropAndDrag.AllowDrop = true;
        }

        private void pictureBoxDropAndDrag_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void buttonNoise_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBoxDropAndDrag.Image;
            pictureBox2.Image = pictureBoxDropAndDrag.Image;
            var image = new Bitmap(pictureBoxDropAndDrag.Image);
            var rand = new Random();
            for (int i = 0; i < (int)(numericUpDown1.Value/100*image.Height*image.Width); i++)
            {
                int x = rand.Next(pictureBoxDropAndDrag.Image.Width);
                int y = rand.Next(pictureBoxDropAndDrag.Image.Height);
                Color color = rand.NextDouble() < 0.5 ? Color.White : Color.Black;
                image.SetPixel(x, y, color);
            }
            pictureBox1.Image = image;
            pictureBox2.Image = image;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            var image = new Bitmap(pictureBox2.Image);
            image = this.Pad(image, 2);
            List<Color> listPixels = new List<Color>();
            List<int> R = new List<int>();
            List<int> G = new List<int>();
            List<int> B = new List<int>();
            for (int i = 2; i < pictureBox2.Image.Width + 2; i++)
            {
                for (int j = 2; j < pictureBox2.Image.Height + 2; j++)
                {
                    listPixels.Clear();
                    R.Clear();
                    G.Clear();
                    B.Clear();
                    listPixels.Add(image.GetPixel(i - 2, j));
                    listPixels.Add(image.GetPixel(i - 1, j));
                    listPixels.Add(image.GetPixel(i, j));
                    listPixels.Add(image.GetPixel(i + 1, j));
                    listPixels.Add(image.GetPixel(i + 2, j));
                    listPixels.Add(image.GetPixel(i, j - 2));
                    listPixels.Add(image.GetPixel(i, j - 1));
                    listPixels.Add(image.GetPixel(i, j + 1));
                    listPixels.Add(image.GetPixel(i, j + 2));
                    foreach(var pixel in listPixels)
                    {
                        R.Add(pixel.R);
                        G.Add(pixel.G);
                        B.Add(pixel.B);
                    }
                    R.Sort();
                    G.Sort();
                    B.Sort();
                    Color color = Color.FromArgb(R[(R.Count - 1) / 2], G[(G.Count - 1) / 2], B[(B.Count - 1) / 2]);
                    image.SetPixel(i, j, color);
                }
            }
            pictureBox2.Image = image;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"../../../Data/Noise.png", ImageFormat.Png);
            pictureBox2.Image.Save(@"../../../Data/Filtering.png", ImageFormat.Png);
        }
        private Bitmap Pad(Bitmap img, int border)
        {
            int w = img.Width;
            int h = img.Height;
            int wp = w + 2 * border;
            int hp = h + 2 * border;
            Bitmap ri = new Bitmap(wp, hp);
            BitmapData rd = ri.LockBits(new Rectangle(0, 0, wp, hp),
                ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            BitmapData id = img.LockBits(new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int imgb = id.Stride * id.Height;
            int borb = rd.Stride * rd.Height;
            byte[] imga = new byte[imgb];
            byte[] bora = new byte[borb];
            for (int i = 3; i < borb; i += 4)
            {
                bora[i] = 255;
            }
            System.Runtime.InteropServices.Marshal.Copy(id.Scan0, imga, 0, imgb);
            img.UnlockBits(id);
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    int ip = y * id.Stride + x * 4;
                    int rp = y * rd.Stride + x * 4;
                    for (int i = 0; i < 3; i++)
                    {
                        bora[(rd.Stride + 4) * border + rp + i] = imga[ip + i];
                    }
                }
            }
            System.Runtime.InteropServices.Marshal.Copy(bora, 0, rd.Scan0, borb);
            ri.UnlockBits(rd);
            return ri;
        }
    }
}
