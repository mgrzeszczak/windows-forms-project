using System;
using System.Collections.Generic;
using System.Drawing;

namespace pwsgl3
{
    public interface Shape
    {
        void Draw(Pen pen, Graphics g);
        void Update(Point location);
    }

    public enum ShapeType
    {
        LINE, RECTANGLE, ELLIPSE, SPRAY
    }

    public class ShapeFactory
    {
        private Random random;

        public ShapeFactory()
        {
            this.random = new Random();
        }

        public Shape CreateShape(ShapeType type,Point location, Color contourColor, Color fillColor, bool fill)
        {
            switch (type)
            {
                case ShapeType.LINE:
                    return new Line(location, contourColor,fillColor,fill);
                case ShapeType.RECTANGLE:
                    return new Rectangle(location, contourColor, fillColor, fill);
                case ShapeType.ELLIPSE:
                    return new Ellipse(location, contourColor, fillColor, fill);
                case ShapeType.SPRAY:
                    return new Spray(random,contourColor, fillColor, fill);
                default:
                    throw new ArgumentException();
            }
        }

        private abstract class AbstractShape : Shape
        {
            protected Color contourColor, fillColor;
            protected bool fill;
            public AbstractShape(Color contourColor, Color fillColor, bool fill)
            {
                this.contourColor = contourColor;
                this.fillColor = fillColor;
                this.fill = fill;
            }

            public abstract void Draw(Pen pen, Graphics g);
            public abstract void Update(Point location);
        }

        private class Spray : AbstractShape
        {
            private List<Point> points;

            private const double DEVIATION = 7.0d;
            private const int AMOUNT = 50;

            private Random random;

            public Spray(Random random, Color contourColor, Color fillColor, bool fill) : base(contourColor, fillColor, fill)
            {
                this.random = random;
                this.points = new List<Point>();
            }

            public override void Draw(Pen pen, Graphics g)
            {
                pen.Color = contourColor;
                points.ForEach(p => g.DrawLine(pen, p, new Point(p.X + 1, p.Y + 1)));
            }

            public override void Update(Point location)
            {
                for (int i = 0; i < AMOUNT; i++)
                {
                    points.Add(NextGaussianDistrubutionPoint(location));
                }
            }

            private Point NextGaussianDistrubutionPoint(Point p)
            {
                double randStdNormalX = Math.Sqrt(-2.0 * Math.Log(random.NextDouble())) *
                             Math.Sin(2.0 * Math.PI * random.NextDouble());
                double randStdNormalY = Math.Sqrt(-2.0 * Math.Log(random.NextDouble())) *
                             Math.Sin(2.0 * Math.PI * random.NextDouble());

                int randX = (int)(p.X + DEVIATION * randStdNormalX);
                int randY = (int)(p.Y + DEVIATION * randStdNormalY);

                return new Point(randX, randY);
            }
        }

        private class Line : AbstractShape
        {
            public Line(Point location, Color contourColor, Color fillColor, bool fill) : base(contourColor, fillColor, fill)
            {
                p2 = p1 = location;
            }

            public Point p1 { get; set; }
            public Point p2 { get; set; }

            public override void Draw(Pen pen, Graphics g)
            {
                pen.Color = contourColor;
                g.DrawLine(pen, p1, p2);
            }

            public override void Update(Point location)
            {
                p2 = location;
            }
        }
        private class Rectangle : AbstractShape
        {
            public Rectangle(Point location, Color contourColor, Color fillColor, bool fill) : base(contourColor, fillColor, fill)
            {
                p1 = location;
            }

            public Point p1 { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public override void Draw(Pen pen, Graphics g)
            {
                int drawX = Width >= 0 ? p1.X : p1.X + Width;
                int drawY = Height >= 0 ? p1.Y : p1.Y + Height;
                Point p = new Point(drawX, drawY);
                int drawWidth = Math.Abs(Width);
                int drawHeight = Math.Abs(Height);

                if (fill)
                {
                    pen.Color = fillColor;
                    g.FillRectangle(pen.Brush, p.X, p.Y, drawWidth, drawHeight);
                }
                pen.Color = contourColor;
                g.DrawRectangle(pen, p.X, p.Y, drawWidth, drawHeight);
            }

            public override void Update(Point location)
            {
                Width = location.X - p1.X;
                Height = location.Y - p1.Y;
            }
        }
        private class Ellipse : AbstractShape
        {
            public Ellipse(Point location, Color contourColor, Color fillColor, bool fill) : base(contourColor, fillColor, fill)
            {
                p1 = location;
            }

            public Point p1 { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public override void Draw(Pen pen, Graphics g)
            {
                if (fill)
                {
                    pen.Color = fillColor;
                    g.FillEllipse(pen.Brush, p1.X, p1.Y, Width, Height);
                }
                pen.Color = contourColor;
                g.DrawEllipse(pen, p1.X, p1.Y, Width, Height);
            }

            public override void Update(Point location)
            {
                Width = location.X - p1.X;
                Height = location.Y - p1.Y;
            }
        }
    }

}
