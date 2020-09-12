using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace App_GIIS
{
    public partial class FormBMP : Form
    {
        private Bitmap bitmap;
        public FormBMP()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(Image.FromFile(openFileDialog1.FileName));
                pictureBox1.Image = bitmap;
                double scale = Convert.ToDouble(trackBar1.Value / 10.0);
                textBox1.AppendText("Размер: " + pictureBox1.Image.Width.ToString() + "x" + pictureBox1.Image.Height.ToString() + "   Растяжение: x" + scale.ToString());
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("Формат файла изображения: " + pictureBox1.Image.RawFormat.ToString());
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("Формат пиксела: " + pictureBox1.Image.PixelFormat.ToString());
            }
        }

        private void buttonCloseImage_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            pictureBox1.Image = null;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                double scale = Convert.ToDouble(trackBar1.Value / 10.0);
                pictureBox1.Image = ResizeImage(pictureBox1.Image, (int)(bitmap.Width * scale), bitmap.Height);
                textBox1.Text = null;
                textBox1.AppendText("Размер: " + pictureBox1.Image.Width.ToString() + "x" + pictureBox1.Image.Height.ToString() + "   Растяжение: x" + scale.ToString());
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("Формат файла изображения: " + pictureBox1.Image.RawFormat.ToString());
                textBox1.AppendText(Environment.NewLine);
                textBox1.AppendText("Формат пиксела: " + pictureBox1.Image.PixelFormat.ToString());
            }
            else trackBar1.Value = 10;
        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.OpenFile(), ImageFormat.Bmp);
            }
        }
    }
}
