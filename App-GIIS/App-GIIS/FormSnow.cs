using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace App_GIIS
{
    public partial class FormSnow : Form
    {
        private Random random = new Random();
        private System.Timers.Timer time = new System.Timers.Timer();
        private List<Snowflake> snowflakes = new List<Snowflake>();
        Graphics graphics;
        public FormSnow()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSnow_Paint(object sender, PaintEventArgs e)
        {
            this.Snowfall();
        }
        private void DrawSnowflakes(Snowflake snowflake)
        {
            graphics = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(snowflake.Color);
            graphics.FillEllipse(brush, snowflake.Coordinate.X, snowflake.Coordinate.Y, snowflake.Size, snowflake.Size);
        }

        private void FormSnow_Load(object sender, EventArgs e)
        {
        }
        private void Snowfall()
        {
            if (snowflakes.Count < 200)
            {
                int blueColor = random.Next(0, 127) + 128;
                snowflakes.Add(new Snowflake(new Point(random.Next(0, this.Width), 0), Color.FromArgb(blueColor / 2, blueColor / 2, blueColor), random.Next(1, 10), this.Height));
            }
            List<Snowflake> removeSnowflakes = new List<Snowflake>();
            foreach (var snowflake in snowflakes)
            {
                if (snowflake.Health > 0)
                {
                    snowflake.Move();
                    DrawSnowflakes(snowflake);
                }
                else removeSnowflakes.Add(snowflake);
            }
            foreach (var snowflake in removeSnowflakes)
                snowflakes.Remove(snowflake);
            removeSnowflakes.Clear();
            this.Invalidate();
        }
    }
}
