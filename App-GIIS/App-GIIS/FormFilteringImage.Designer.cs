namespace App_GIIS
{
    partial class FormFilteringImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilteringImage));
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDropAndDrag = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDropAndDrag)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.BackColor = System.Drawing.Color.Indigo;
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(997, -1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(32, 32);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonNoise);
            this.panel1.Controls.Add(this.labelHeight);
            this.panel1.Controls.Add(this.labelWidth);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxDropAndDrag);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 692);
            this.panel1.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Indigo;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(374, 627);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(166, 39);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNoise
            // 
            this.buttonNoise.BackColor = System.Drawing.Color.Indigo;
            this.buttonNoise.FlatAppearance.BorderSize = 0;
            this.buttonNoise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNoise.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNoise.ForeColor = System.Drawing.Color.White;
            this.buttonNoise.Location = new System.Drawing.Point(30, 627);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(166, 39);
            this.buttonNoise.TabIndex = 4;
            this.buttonNoise.Text = "Зашумить";
            this.buttonNoise.UseVisualStyleBackColor = false;
            this.buttonNoise.Click += new System.EventHandler(this.buttonNoise_Click);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelHeight.ForeColor = System.Drawing.Color.White;
            this.labelHeight.Location = new System.Drawing.Point(164, 69);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(73, 21);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Высота";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWidth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelWidth.ForeColor = System.Drawing.Color.White;
            this.labelWidth.Location = new System.Drawing.Point(52, 142);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(81, 21);
            this.labelWidth.TabIndex = 3;
            this.labelWidth.Text = "Ширина";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(128, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(725, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отфильтрованное изображение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(390, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Зашумленное изображение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Исходное изображение";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.Indigo;
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFilter.ForeColor = System.Drawing.Color.White;
            this.buttonFilter.Location = new System.Drawing.Point(202, 627);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(166, 39);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Отфильтровать";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "%";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(30, 572);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(103, 32);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(689, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 340);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(343, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxDropAndDrag
            // 
            this.pictureBoxDropAndDrag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDropAndDrag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDropAndDrag.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDropAndDrag.Image")));
            this.pictureBoxDropAndDrag.Location = new System.Drawing.Point(-1, 168);
            this.pictureBoxDropAndDrag.Name = "pictureBoxDropAndDrag";
            this.pictureBoxDropAndDrag.Size = new System.Drawing.Size(340, 340);
            this.pictureBoxDropAndDrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDropAndDrag.TabIndex = 1;
            this.pictureBoxDropAndDrag.TabStop = false;
            this.pictureBoxDropAndDrag.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxDropAndDrag_DragDrop);
            this.pictureBoxDropAndDrag.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxDropAndDrag_DragEnter);
            // 
            // FormFilteringImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1030, 692);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFilteringImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FormFilteringImage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDropAndDrag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxDropAndDrag;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonNoise;
        private System.Windows.Forms.Button buttonSave;
    }
}