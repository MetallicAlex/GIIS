using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GIIS
{
    public partial class FormMain : Form
    {
        private bool dragMainForm = false;
        private Point startPositionMainForm = new Point(0, 0);
        private Form activeForm = null;
        public FormMain()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Close_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("../../../Data/test2.jpg");
            System.IO.File.Delete("../../../Data/test.jpg");
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonFilteringImage_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FormFilteringImage());
        }
        #region functions of panel Header
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragMainForm = true;
            startPositionMainForm = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragMainForm)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - startPositionMainForm.X, point.Y - startPositionMainForm.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragMainForm = false;
        }
        #endregion

        private void buttonMaxRestore_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                buttonMaxRestore.BackgroundImage = Image.FromFile(@"../../../Data/Launcher/ButtonMaximize.png");
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                buttonMaxRestore.BackgroundImage = Image.FromFile(@"../../../Data/Launcher/ButtonRestore.png");
            }
        }

        private void buttonFindContours_Click(object sender, EventArgs e)
        {
            this.OpenChildForm(new FormFindContours());
        }
    }
}
