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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaxRestore = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonBMP = new System.Windows.Forms.Button();
            this.buttonSnow = new System.Windows.Forms.Button();
            this.buttonFindContours = new System.Windows.Forms.Button();
            this.buttonFilteringImage = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.buttonMinimize);
            this.panelHeader.Controls.Add(this.buttonMaxRestore);
            this.panelHeader.Controls.Add(this.buttonClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1280, 32);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
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
            this.buttonMaxRestore.Click += new System.EventHandler(this.buttonMaxRestore_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(1248, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.BackgroundImage")));
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureLogo.InitialImage")));
            this.pictureLogo.Location = new System.Drawing.Point(0, 624);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(64, 64);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureLogo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 688);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonBMP);
            this.panel3.Controls.Add(this.buttonSnow);
            this.panel3.Controls.Add(this.buttonFindContours);
            this.panel3.Controls.Add(this.buttonFilteringImage);
            this.panel3.Location = new System.Drawing.Point(12, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 329);
            this.panel3.TabIndex = 0;
            // 
            // buttonBMP
            // 
            this.buttonBMP.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBMP.FlatAppearance.BorderSize = 0;
            this.buttonBMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.buttonBMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.buttonBMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBMP.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBMP.ForeColor = System.Drawing.Color.White;
            this.buttonBMP.Location = new System.Drawing.Point(0, 234);
            this.buttonBMP.Name = "buttonBMP";
            this.buttonBMP.Size = new System.Drawing.Size(238, 78);
            this.buttonBMP.TabIndex = 0;
            this.buttonBMP.Text = "Растягивание в ширину в M раз";
            this.buttonBMP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBMP.UseVisualStyleBackColor = true;
            this.buttonBMP.Click += new System.EventHandler(this.buttonBMP_Click);
            // 
            // buttonSnow
            // 
            this.buttonSnow.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSnow.FlatAppearance.BorderSize = 0;
            this.buttonSnow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.buttonSnow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.buttonSnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSnow.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSnow.ForeColor = System.Drawing.Color.White;
            this.buttonSnow.Location = new System.Drawing.Point(0, 156);
            this.buttonSnow.Name = "buttonSnow";
            this.buttonSnow.Size = new System.Drawing.Size(238, 78);
            this.buttonSnow.TabIndex = 0;
            this.buttonSnow.Text = "Снег";
            this.buttonSnow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSnow.UseVisualStyleBackColor = true;
            this.buttonSnow.Click += new System.EventHandler(this.buttonSnow_Click);
            // 
            // buttonFindContours
            // 
            this.buttonFindContours.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFindContours.FlatAppearance.BorderSize = 0;
            this.buttonFindContours.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.buttonFindContours.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.buttonFindContours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindContours.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindContours.ForeColor = System.Drawing.Color.White;
            this.buttonFindContours.Location = new System.Drawing.Point(0, 78);
            this.buttonFindContours.Name = "buttonFindContours";
            this.buttonFindContours.Size = new System.Drawing.Size(238, 78);
            this.buttonFindContours.TabIndex = 0;
            this.buttonFindContours.Text = "Выделение Контуров";
            this.buttonFindContours.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFindContours.UseVisualStyleBackColor = true;
            this.buttonFindContours.Click += new System.EventHandler(this.buttonFindContours_Click);
            // 
            // buttonFilteringImage
            // 
            this.buttonFilteringImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFilteringImage.FlatAppearance.BorderSize = 0;
            this.buttonFilteringImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.buttonFilteringImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ГИИС";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonFilteringImage;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaxRestore;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Button buttonFindContours;
        private System.Windows.Forms.Button buttonSnow;
        private System.Windows.Forms.Button buttonBMP;
    }
}

