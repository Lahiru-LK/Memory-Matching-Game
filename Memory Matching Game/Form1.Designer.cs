namespace Memory_Matching_Game
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            TimeLeftCount1 = new Label();
            pb1 = new PictureBox();
            pb3 = new PictureBox();
            pb2 = new PictureBox();
            pb5 = new PictureBox();
            pb6 = new PictureBox();
            pb4 = new PictureBox();
            pb11 = new PictureBox();
            pb12 = new PictureBox();
            pb10 = new PictureBox();
            pb8 = new PictureBox();
            pb9 = new PictureBox();
            pb7 = new PictureBox();
            label4 = new Label();
            lblPointsName = new Label();
            pbHeart1 = new PictureBox();
            pbHeart2 = new PictureBox();
            pbHeart4 = new PictureBox();
            pbHeart3 = new PictureBox();
            pbHeart6 = new PictureBox();
            pbHeart5 = new PictureBox();
            tmrDelay = new System.Windows.Forms.Timer(components);
            tmrHeart = new System.Windows.Forms.Timer(components);
            lblPoints = new Label();
            timer_Left = new System.Windows.Forms.Timer(components);
            TimeLeftCount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Space_Memory_Game_Worksheet;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 651);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pb1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.IndianRed;
            button1.Location = new Point(121, 531);
            button1.Name = "button1";
            button1.Size = new Size(210, 50);
            button1.TabIndex = 1;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TimeLeftCount1
            // 
            TimeLeftCount1.AutoSize = true;
            TimeLeftCount1.BorderStyle = BorderStyle.Fixed3D;
            TimeLeftCount1.Cursor = Cursors.No;
            TimeLeftCount1.FlatStyle = FlatStyle.Popup;
            TimeLeftCount1.Location = new Point(177, 497);
            TimeLeftCount1.Name = "TimeLeftCount1";
            TimeLeftCount1.Size = new Size(100, 22);
            TimeLeftCount1.TabIndex = 2;
            TimeLeftCount1.Text = "Time Left : 60";
            TimeLeftCount1.Click += label1_Click;
            // 
            // pb1
            // 
            pb1.Image = (Image)resources.GetObject("pb1.Image");
            pb1.Location = new Point(99, 112);
            pb1.Name = "pb1";
            pb1.Size = new Size(82, 73);
            pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            pb1.TabIndex = 3;
            pb1.TabStop = false;
            pb1.Tag = "0";
            pb1.Click += pb1_Click;
            // 
            // pb3
            // 
            pb3.Image = (Image)resources.GetObject("pb3.Image");
            pb3.Location = new Point(275, 112);
            pb3.Name = "pb3";
            pb3.Size = new Size(82, 73);
            pb3.SizeMode = PictureBoxSizeMode.StretchImage;
            pb3.TabIndex = 4;
            pb3.TabStop = false;
            pb3.Tag = "0";
            pb3.Click += pb1_Click;
            // 
            // pb2
            // 
            pb2.Image = (Image)resources.GetObject("pb2.Image");
            pb2.Location = new Point(187, 112);
            pb2.Name = "pb2";
            pb2.Size = new Size(82, 73);
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            pb2.TabIndex = 5;
            pb2.TabStop = false;
            pb2.Tag = "0";
            pb2.Click += pb1_Click;
            // 
            // pb5
            // 
            pb5.Image = (Image)resources.GetObject("pb5.Image");
            pb5.Location = new Point(187, 191);
            pb5.Name = "pb5";
            pb5.Size = new Size(82, 73);
            pb5.SizeMode = PictureBoxSizeMode.StretchImage;
            pb5.TabIndex = 8;
            pb5.TabStop = false;
            pb5.Tag = "0";
            pb5.Click += pb1_Click;
            // 
            // pb6
            // 
            pb6.Image = (Image)resources.GetObject("pb6.Image");
            pb6.Location = new Point(275, 191);
            pb6.Name = "pb6";
            pb6.Size = new Size(82, 73);
            pb6.SizeMode = PictureBoxSizeMode.StretchImage;
            pb6.TabIndex = 7;
            pb6.TabStop = false;
            pb6.Tag = "0";
            pb6.Click += pb1_Click;
            // 
            // pb4
            // 
            pb4.Image = (Image)resources.GetObject("pb4.Image");
            pb4.Location = new Point(99, 191);
            pb4.Name = "pb4";
            pb4.Size = new Size(82, 73);
            pb4.SizeMode = PictureBoxSizeMode.StretchImage;
            pb4.TabIndex = 6;
            pb4.TabStop = false;
            pb4.Tag = "0";
            pb4.Click += pb1_Click;
            // 
            // pb11
            // 
            pb11.Image = (Image)resources.GetObject("pb11.Image");
            pb11.Location = new Point(187, 351);
            pb11.Name = "pb11";
            pb11.Size = new Size(82, 73);
            pb11.SizeMode = PictureBoxSizeMode.StretchImage;
            pb11.TabIndex = 14;
            pb11.TabStop = false;
            pb11.Tag = "0";
            pb11.Click += pb1_Click;
            // 
            // pb12
            // 
            pb12.Image = (Image)resources.GetObject("pb12.Image");
            pb12.Location = new Point(275, 351);
            pb12.Name = "pb12";
            pb12.Size = new Size(82, 73);
            pb12.SizeMode = PictureBoxSizeMode.StretchImage;
            pb12.TabIndex = 13;
            pb12.TabStop = false;
            pb12.Tag = "0";
            pb12.Click += pb1_Click;
            // 
            // pb10
            // 
            pb10.Image = (Image)resources.GetObject("pb10.Image");
            pb10.Location = new Point(99, 351);
            pb10.Name = "pb10";
            pb10.Size = new Size(82, 73);
            pb10.SizeMode = PictureBoxSizeMode.StretchImage;
            pb10.TabIndex = 12;
            pb10.TabStop = false;
            pb10.Tag = "0";
            pb10.Click += pb1_Click;
            // 
            // pb8
            // 
            pb8.Image = (Image)resources.GetObject("pb8.Image");
            pb8.Location = new Point(187, 272);
            pb8.Name = "pb8";
            pb8.Size = new Size(82, 73);
            pb8.SizeMode = PictureBoxSizeMode.StretchImage;
            pb8.TabIndex = 11;
            pb8.TabStop = false;
            pb8.Tag = "0";
            pb8.Click += pb1_Click;
            // 
            // pb9
            // 
            pb9.Image = (Image)resources.GetObject("pb9.Image");
            pb9.Location = new Point(275, 272);
            pb9.Name = "pb9";
            pb9.Size = new Size(82, 73);
            pb9.SizeMode = PictureBoxSizeMode.StretchImage;
            pb9.TabIndex = 10;
            pb9.TabStop = false;
            pb9.Tag = "0";
            pb9.Click += pb1_Click;
            // 
            // pb7
            // 
            pb7.Image = (Image)resources.GetObject("pb7.Image");
            pb7.Location = new Point(99, 272);
            pb7.Name = "pb7";
            pb7.Size = new Size(82, 73);
            pb7.SizeMode = PictureBoxSizeMode.StretchImage;
            pb7.TabIndex = 9;
            pb7.TabStop = false;
            pb7.Tag = "0";
            pb7.Click += pb1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Cursor = Cursors.No;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Location = new Point(105, 466);
            label4.Name = "label4";
            label4.Size = new Size(46, 22);
            label4.TabIndex = 17;
            label4.Text = "Life : ";
            label4.Click += label4_Click;
            // 
            // lblPointsName
            // 
            lblPointsName.AutoSize = true;
            lblPointsName.BorderStyle = BorderStyle.Fixed3D;
            lblPointsName.Cursor = Cursors.No;
            lblPointsName.FlatStyle = FlatStyle.Popup;
            lblPointsName.Location = new Point(105, 436);
            lblPointsName.Name = "lblPointsName";
            lblPointsName.Size = new Size(55, 22);
            lblPointsName.TabIndex = 18;
            lblPointsName.Text = "Point : ";
            lblPointsName.Click += label5_Click;
            // 
            // pbHeart1
            // 
            pbHeart1.BorderStyle = BorderStyle.Fixed3D;
            pbHeart1.Image = Properties.Resources.hart;
            pbHeart1.Location = new Point(157, 466);
            pbHeart1.Name = "pbHeart1";
            pbHeart1.Size = new Size(20, 20);
            pbHeart1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeart1.TabIndex = 19;
            pbHeart1.TabStop = false;
            // 
            // pbHeart2
            // 
            pbHeart2.BorderStyle = BorderStyle.Fixed3D;
            pbHeart2.Image = Properties.Resources.hart;
            pbHeart2.Location = new Point(183, 466);
            pbHeart2.Name = "pbHeart2";
            pbHeart2.Size = new Size(20, 20);
            pbHeart2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeart2.TabIndex = 20;
            pbHeart2.TabStop = false;
            // 
            // pbHeart4
            // 
            pbHeart4.BorderStyle = BorderStyle.Fixed3D;
            pbHeart4.Image = Properties.Resources.hart;
            pbHeart4.Location = new Point(235, 466);
            pbHeart4.Name = "pbHeart4";
            pbHeart4.Size = new Size(20, 20);
            pbHeart4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeart4.TabIndex = 22;
            pbHeart4.TabStop = false;
            // 
            // pbHeart3
            // 
            pbHeart3.BorderStyle = BorderStyle.Fixed3D;
            pbHeart3.Image = Properties.Resources.hart;
            pbHeart3.Location = new Point(209, 466);
            pbHeart3.Name = "pbHeart3";
            pbHeart3.Size = new Size(20, 20);
            pbHeart3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeart3.TabIndex = 21;
            pbHeart3.TabStop = false;
            // 
            // pbHeart6
            // 
            pbHeart6.BorderStyle = BorderStyle.Fixed3D;
            pbHeart6.Image = (Image)resources.GetObject("pbHeart6.Image");
            pbHeart6.Location = new Point(284, 466);
            pbHeart6.Name = "pbHeart6";
            pbHeart6.Size = new Size(20, 20);
            pbHeart6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeart6.TabIndex = 24;
            pbHeart6.TabStop = false;
            // 
            // pbHeart5
            // 
            pbHeart5.BorderStyle = BorderStyle.Fixed3D;
            pbHeart5.Image = Properties.Resources.hart;
            pbHeart5.Location = new Point(258, 466);
            pbHeart5.Name = "pbHeart5";
            pbHeart5.Size = new Size(20, 20);
            pbHeart5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeart5.TabIndex = 23;
            pbHeart5.TabStop = false;
            // 
            // tmrDelay
            // 
            tmrDelay.Interval = 2000;
            tmrDelay.Tick += tmrDelay_Tick;
            // 
            // tmrHeart
            // 
            tmrHeart.Interval = 200;
            tmrHeart.Tick += tmrHeart_Tick;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.BorderStyle = BorderStyle.Fixed3D;
            lblPoints.Cursor = Cursors.No;
            lblPoints.FlatStyle = FlatStyle.Popup;
            lblPoints.Location = new Point(157, 436);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(19, 22);
            lblPoints.TabIndex = 25;
            lblPoints.Text = "0";
            // 
            // timer_Left
            // 
            timer_Left.Tick += timer_Left_Tick;
            // 
            // TimeLeftCount
            // 
            TimeLeftCount.AutoSize = true;
            TimeLeftCount.BorderStyle = BorderStyle.Fixed3D;
            TimeLeftCount.Cursor = Cursors.No;
            TimeLeftCount.FlatStyle = FlatStyle.Popup;
            TimeLeftCount.Location = new Point(251, 497);
            TimeLeftCount.Name = "TimeLeftCount";
            TimeLeftCount.Size = new Size(27, 22);
            TimeLeftCount.TabIndex = 26;
            TimeLeftCount.Text = "60";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(452, 651);
            Controls.Add(TimeLeftCount);
            Controls.Add(lblPoints);
            Controls.Add(pbHeart6);
            Controls.Add(pbHeart5);
            Controls.Add(pbHeart4);
            Controls.Add(pbHeart3);
            Controls.Add(pbHeart2);
            Controls.Add(pbHeart1);
            Controls.Add(lblPointsName);
            Controls.Add(label4);
            Controls.Add(pb11);
            Controls.Add(pb12);
            Controls.Add(pb10);
            Controls.Add(pb8);
            Controls.Add(pb9);
            Controls.Add(pb7);
            Controls.Add(pb5);
            Controls.Add(pb6);
            Controls.Add(pb4);
            Controls.Add(pb2);
            Controls.Add(pb3);
            Controls.Add(pb1);
            Controls.Add(TimeLeftCount1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            ForeColor = Color.IndianRed;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Memory Matching Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHeart5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label TimeLeftCount1;
        private PictureBox pb1;
        private PictureBox pb3;
        private PictureBox pb2;
        private PictureBox pb5;
        private PictureBox pb6;
        private PictureBox pb4;
        private PictureBox pb11;
        private PictureBox pb12;
        private PictureBox pb10;
        private PictureBox pb8;
        private PictureBox pb9;
        private PictureBox pb7;
        private Label label4;
        private Label lblPointsName;
        private PictureBox pbHeart1;
        private PictureBox pbHeart2;
        private PictureBox pbHeart4;
        private PictureBox pbHeart3;
        private PictureBox pbHeart6;
        private PictureBox pbHeart5;
        private System.Windows.Forms.Timer tmrDelay;
        private System.Windows.Forms.Timer tmrHeart;
        private Label lblPoints;
        private System.Windows.Forms.Timer timer_Left;
        private Label TimeLeftCount;
    }
}
