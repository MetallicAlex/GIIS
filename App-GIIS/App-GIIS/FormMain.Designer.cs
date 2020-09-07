namespace App_GIIS
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaxRestore = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonFilteringImage = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonMaxRestore);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 32);
            this.panel1.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(1184, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(32, 32);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaxRestore
            // 
            this.buttonMaxRestore.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaxRestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaxRestore.BackgroundImage")));
            this.buttonMaxRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMaxRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaxRestore.FlatAppearance.BorderSize = 0;
            this.buttonMaxRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonMaxRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonMaxRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaxRestore.Location = new System.Drawing.Point(1216, 0);
            this.buttonMaxRestore.Name = "buttonMaxRestore";
            this.buttonMaxRestore.Size = new System.Drawing.Size(32, 32);
            this.buttonMaxRestore.TabIndex = 0;
            this.buttonMaxRestore.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(1248, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 0;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 688);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonFilteringImage);
            this.panel3.Location = new System.Drawing.Point(12, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 291);
            this.panel3.TabIndex = 0;
            // 
            // buttonFilteringImage
            // 
            this.buttonFilteringImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFilteringImage.FlatAppearance.BorderSize = 0;
            this.buttonFilteringImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonFilteringImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonFilteringImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilteringImage.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFilteringImage.ForeColor = System.Drawing.Color.White;
            this.buttonFilteringImage.Location = new System.Drawing.Point(0, 0);
            this.buttonFilteringImage.Name = "buttonFilteringImage";
            this.buttonFilteringImage.Size = new System.Drawing.Size(238, 78);
            this.buttonFilteringImage.TabIndex = 0;
            this.buttonFilteringImage.Text = "Фильтрация Изображений";
            this.buttonFilteringImage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFilteringImage.UseVisualStyleBackColor = true;
            this.buttonFilteringImage.Click += new System.EventHandler(this.buttonFilteringImage_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 32);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1030, 688);
            this.panelChildForm.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ГИИС";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFilteringImage;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button buttonMaxRestore;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

