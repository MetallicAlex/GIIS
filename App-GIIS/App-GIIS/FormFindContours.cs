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
    public partial class FormFindContours : Form
    {
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
                }
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"../../../Data/Contours.png", ImageFormat.Png);
        }

        private void buttonFindContours_Click(object sender, EventArgs e)
        {

        }
    }
}
