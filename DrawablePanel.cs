using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace pwsgl3
{
    public partial class DrawablePanel : UserControl
    {
        private const float BRUSH_WIDTH = 4.0f;

        public ShapeType Type {get;set;}
        public bool Fill { get; set; }
        public Color FillColor { get; set; }
        public Color ContourColor { get; set; }

        private ShapeFactory shapeFactory;
        private Shape currShape;
        private Pen pen;
        private Bitmap canvas;

        public DrawablePanel()
        {
            InitializeComponent();
            Type = ShapeType.LINE;
            FillColor = Color.White;
            ContourColor = Color.Black;
            Fill = false;
            pen = new Pen(new SolidBrush(ContourColor),BRUSH_WIDTH);
            canvas = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            shapeFactory = new ShapeFactory();
        }

        public void SaveCanvas()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "PNG|*.png";
            dialog.Title = "Save canvas";
            dialog.ShowDialog();
            if (string.IsNullOrEmpty(dialog.FileName)) return;
            using (System.IO.FileStream fs =
                   (System.IO.FileStream)dialog.OpenFile())
            {
                canvas.Save(fs,ImageFormat.Png);
            }
        }

        public void LoadCanvas()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG|*.png|JPG|*.jpg|BMP|*.bmp";
            dialog.Title = "Load canvas";
            dialog.ShowDialog();
            if (string.IsNullOrEmpty(dialog.FileName)) return;
            Bitmap bmp = (Bitmap)Image.FromFile(dialog.FileName);
            Graphics graphics = Graphics.FromImage(canvas);
            graphics.Clear(Color.Transparent);
            graphics.DrawImage(bmp, new Point(0, 0));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Point point = PointToScreen(new Point(0, 0));
            RectangleF src = new RectangleF(point.X,point.Y,Width,Height);
            RectangleF dst = new RectangleF(0, 0, Width, Height);
            e.Graphics.DrawImage(canvas, dst,src,GraphicsUnit.Pixel);
            if (currShape == null) return;
            Graphics graphics = e.Graphics;
            Matrix transformation = new Matrix();
            transformation.Translate(-point.X, -point.Y);
            graphics.Transform = transformation;
            currShape?.Draw(pen, graphics);
        }

        private void UpdateImage(Shape shape)
        {
            Graphics graphics = Graphics.FromImage(canvas);
            shape.Draw(pen, graphics);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.Cursor = Cursors.Cross;
            Point location = PointToScreen(e.Location);
            currShape = shapeFactory.CreateShape(Type, location, ContourColor, FillColor, Fill);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (currShape == null) return;
            Point location = PointToScreen(e.Location);
            currShape.Update(location);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
            if (currShape == null) return;
            UpdateImage(currShape);
            currShape = null;
            Invalidate();
        }

        
    }
}
