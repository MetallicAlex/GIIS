using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace App_GIIS
{
    public partial class FormFindContours : Form
    {
        private Bitmap bitmap;
        private string sobel = "sobel_x";
        public FormFindContours()
        {
            InitializeComponent();
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = -1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = -2;
            numericUpDown6.Value = -1;
            numericUpDown7.Value = 1;
            numericUpDown8.Value = 1;
            numericUpDown9.Value = -1;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormFindContours_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pictureBox1.Image = Image.FromFile(fileNames[0]);
                    bitmap = this.ConvertToGrayscale(pictureBox1.Image);
                }
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                var image = new Bitmap(pictureBox2.Image);
                image.Save(@"../../../Data/Contours.png");
                //pictureBox2.Image.Save(@"../../../Data/Contours", ImageFormat.Png);
            }
        }

        private void buttonFindContours_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("../../../Data/test.jpg");
            string kernel = numericUpDown1.Value.ToString() + "," +
                numericUpDown2.Value.ToString() + "," +
                numericUpDown3.Value.ToString() + "," +
                numericUpDown4.Value.ToString() + "," +
                numericUpDown5.Value.ToString() + "," +
                numericUpDown6.Value.ToString() + "," +
                numericUpDown7.Value.ToString() + "," +
                numericUpDown8.Value.ToString() + "," +
                numericUpDown9.Value.ToString();
            string strCmdText;
            strCmdText = "/K python ../../../Data/Scripts/convolve.py --image ../../../Data/test.jpg -o ../../../Data/test2.jpg --kernel " + kernel + " --threshold " + numericUpDown10.Value.ToString();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.ArgumentList.Add(strCmdText);
            process.Start();
            process.StandardInput.WriteLine("exit");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
            while (true)
            {
                if (File.Exists("../../../Data/test2.jpg"))
                {
                    Image image = null;
                    FileStream file = null;
                    try
                    {
                        file = new FileStream("../../../Data/test2.jpg", FileMode.Open, FileAccess.Read);
                        image = Image.FromStream(file);
                    }
                    finally
                    {
                        file.Close();
                    }
                    pictureBox2.Image = image;
                    break;
                }
            }
            label2.Visible = true;
        }
        private Bitmap ConvertToGrayscale(Image img)
        {
            Bitmap image = new Bitmap(img);
            for (int i = 0; i < pictureBox1.Image.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Image.Height; j++)
                {
                    Color color = image.GetPixel(i, j);
                    //int grayScale = (int)((color.R * 0.3) + (color.G * 0.59) + (color.B * 0.11));
                    int grayScale = (int)((color.R + color.G + color.B) / 3);
                    Color grayColor = Color.FromArgb(grayScale, grayScale, grayScale);
                    image.SetPixel(i, j, grayColor);
                }
            }
            return image;
        }

        private void buttonOpenCV_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("../../../Data/test.jpg");
            string strCmdText;
            strCmdText = "/K python ../../../Data/Scripts/sobel_convolve.py --image ../../../Data/test.jpg -o ../../../Data/test2.jpg --sobel " + sobel;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.Arguments = strCmdText;
            process.Start();
            process.StandardInput.WriteLine("exit");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
            while (true)
            {
                if (File.Exists("../../../Data/test2.jpg"))
                {
                    Image image = null;
                    FileStream file = null;
                    try
                    {
                        file = new FileStream("../../../Data/test2.jpg", FileMode.Open, FileAccess.Read);
                        image = Image.FromStream(file);
                    }
                    finally
                    {
                        file.Close();
                    }
                    pictureBox2.Image = image;
                    break;
                }
            }
            label2.Visible = true;
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                sobel = radioButton.Text;
            }
        }
    }
}
