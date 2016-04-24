using System;
using System.Drawing;
using System.Windows.Forms;

namespace pwsgl3
{
    public partial class Window : Form
    {

        public Window()
        {
            InitializeComponent();
            comboBox.SelectedIndex = 1;
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            drawablePanel.Type = ShapeType.LINE;
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            drawablePanel.Type = ShapeType.RECTANGLE;
        }

        private void elipseBtn_Click(object sender, EventArgs e)
        {
            drawablePanel.Type = ShapeType.ELLIPSE;
        }

        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            drawablePanel.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawablePanel.SaveCanvas();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawablePanel.LoadCanvas();
        }

        private void edgeColorPictureBox_Click(object sender, EventArgs e)
        {
            Color color = PickColor();
            contourColorPictureBox.BackColor = color;
            drawablePanel.ContourColor = color;
        }

        private void fillColorPictureBox_Click(object sender, EventArgs e)
        {
            Color color = PickColor();
            fillColorPictureBox.BackColor = color;
            drawablePanel.FillColor = color;
        }

        private void fillCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            drawablePanel.Fill = fillCheckBox.Checked;
        }

        private Color PickColor()
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            return dialog.Color.Equals(TransparencyKey) ? Color.FromArgb((TransparencyKey.R+1)%256, TransparencyKey.G, TransparencyKey.G) : dialog.Color;
        }

        private void sprayBtn_Click(object sender, EventArgs e)
        {
            drawablePanel.Type = ShapeType.SPRAY;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawablePanel.Fill = comboBox.SelectedIndex == 0;
        }
    }


}
