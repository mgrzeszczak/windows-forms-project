namespace pwsgl3
{
    partial class Window
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawablePanel = new pwsgl3.DrawablePanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fillColorPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contourColorPictureBox = new System.Windows.Forms.PictureBox();
            this.fillCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sprayBtn = new System.Windows.Forms.Button();
            this.elipseBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.lineBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fillColorPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contourColorPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(631, 330);
            this.splitContainer1.SplitterDistance = 515;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.drawablePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 330);
            this.panel1.TabIndex = 0;
            // 
            // drawablePanel
            // 
            this.drawablePanel.BackColor = System.Drawing.Color.Maroon;
            this.drawablePanel.ContourColor = System.Drawing.Color.Black;
            this.drawablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawablePanel.Fill = false;
            this.drawablePanel.FillColor = System.Drawing.Color.White;
            this.drawablePanel.Location = new System.Drawing.Point(0, 0);
            this.drawablePanel.Name = "drawablePanel";
            this.drawablePanel.Size = new System.Drawing.Size(515, 330);
            this.drawablePanel.TabIndex = 0;
            this.drawablePanel.Type = pwsgl3.ShapeType.LINE;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.comboBox);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.fillCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customize";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Fill Enabled",
            "Fill Disabled"});
            this.comboBox.Location = new System.Drawing.Point(7, 20);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(93, 21);
            this.comboBox.TabIndex = 3;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fillColorPictureBox);
            this.groupBox4.Location = new System.Drawing.Point(7, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(90, 46);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fill color";
            // 
            // fillColorPictureBox
            // 
            this.fillColorPictureBox.BackColor = System.Drawing.Color.White;
            this.fillColorPictureBox.Location = new System.Drawing.Point(7, 20);
            this.fillColorPictureBox.Name = "fillColorPictureBox";
            this.fillColorPictureBox.Size = new System.Drawing.Size(80, 20);
            this.fillColorPictureBox.TabIndex = 0;
            this.fillColorPictureBox.TabStop = false;
            this.fillColorPictureBox.Click += new System.EventHandler(this.fillColorPictureBox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.contourColorPictureBox);
            this.groupBox3.Location = new System.Drawing.Point(7, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contour color";
            // 
            // contourColorPictureBox
            // 
            this.contourColorPictureBox.BackColor = System.Drawing.Color.Black;
            this.contourColorPictureBox.Location = new System.Drawing.Point(6, 19);
            this.contourColorPictureBox.Name = "contourColorPictureBox";
            this.contourColorPictureBox.Size = new System.Drawing.Size(80, 20);
            this.contourColorPictureBox.TabIndex = 1;
            this.contourColorPictureBox.TabStop = false;
            this.contourColorPictureBox.Click += new System.EventHandler(this.edgeColorPictureBox_Click);
            // 
            // fillCheckBox
            // 
            this.fillCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillCheckBox.Location = new System.Drawing.Point(7, 20);
            this.fillCheckBox.Name = "fillCheckBox";
            this.fillCheckBox.Size = new System.Drawing.Size(55, 17);
            this.fillCheckBox.TabIndex = 0;
            this.fillCheckBox.Text = "Fill";
            this.fillCheckBox.UseVisualStyleBackColor = true;
            this.fillCheckBox.CheckedChanged += new System.EventHandler(this.fillCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.sprayBtn);
            this.groupBox1.Controls.Add(this.elipseBtn);
            this.groupBox1.Controls.Add(this.squareBtn);
            this.groupBox1.Controls.Add(this.lineBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing";
            // 
            // sprayBtn
            // 
            this.sprayBtn.BackgroundImage = global::pwsgl3.Properties.Resources.Spray;
            this.sprayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sprayBtn.Location = new System.Drawing.Point(7, 108);
            this.sprayBtn.Name = "sprayBtn";
            this.sprayBtn.Size = new System.Drawing.Size(90, 23);
            this.sprayBtn.TabIndex = 3;
            this.sprayBtn.UseVisualStyleBackColor = true;
            this.sprayBtn.Click += new System.EventHandler(this.sprayBtn_Click);
            // 
            // elipseBtn
            // 
            this.elipseBtn.BackgroundImage = global::pwsgl3.Properties.Resources.Ellipse;
            this.elipseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.elipseBtn.Location = new System.Drawing.Point(7, 79);
            this.elipseBtn.Name = "elipseBtn";
            this.elipseBtn.Size = new System.Drawing.Size(90, 23);
            this.elipseBtn.TabIndex = 2;
            this.elipseBtn.UseVisualStyleBackColor = true;
            this.elipseBtn.Click += new System.EventHandler(this.elipseBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.BackgroundImage = global::pwsgl3.Properties.Resources.Rectangle;
            this.squareBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.squareBtn.Location = new System.Drawing.Point(7, 50);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(90, 23);
            this.squareBtn.TabIndex = 1;
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // lineBtn
            // 
            this.lineBtn.BackColor = System.Drawing.Color.Transparent;
            this.lineBtn.BackgroundImage = global::pwsgl3.Properties.Resources.Line;
            this.lineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineBtn.Location = new System.Drawing.Point(7, 20);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(90, 23);
            this.lineBtn.TabIndex = 0;
            this.lineBtn.UseVisualStyleBackColor = false;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 354);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Window";
            this.Text = "DrawingTransparent";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fillColorPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contourColorPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button elipseBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Panel panel1;
        private DrawablePanel drawablePanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox fillCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox fillColorPictureBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox contourColorPictureBox;
        private System.Windows.Forms.Button sprayBtn;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

