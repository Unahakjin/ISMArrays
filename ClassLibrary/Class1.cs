using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary
{
   public abstract class ShapePoint
   {
        protected Color color;
        protected int x1;
        protected int y1;
        public ShapePoint(Color color, int x, int y)
        {
            this.color = color;
            x1 = x;
            y1 = y;
        }
        public abstract void Draw(Graphics g);
   }
    public class Dot : ShapePoint
    {
        public Dot(Color color, int x, int y) : base(color, x, y)
        {

        }

        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, x1 - 1, y1 - 1, 2, 2);
        }
    }
    public class Line : Dot
    {
        protected int x2;
        protected int y2;
        public Line(Color color, int x1, int y1, int x2, int y2) : base(color, x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 5);
            g.DrawLine(pen, x1, y1, x2, y2);
        }
    }
    public class Rectangle : Line
    {
        protected int width;
        protected int height;
        public Rectangle(Color color, int x1, int y1, int width, int height) : base(color, x1, y1, width, height)
        {
            this.height = height;
            this.width = width;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 3);
            g.DrawRectangle(pen, x1, y1, width, height);
        }
    }
    public class Circle : Dot
    {
        protected int rad;
        public Circle(Color color, int x1, int y1, int rad) : base(color, x1, y1)
        {
            this.rad = rad;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 5);
            g.DrawEllipse(pen, x1 - 1, y1 - 1, rad, rad);
        }
    }
    public class Ellipse : Dot
    {
        protected int rad1;
        protected int rad2;
        public Ellipse(Color color, int x1, int y1, int rad1, int rad2) : base(color, x1, y1)
        {
            this.rad1 = rad1;
            this.rad2 = rad2;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(color, 5);
            g.DrawEllipse(pen, x1 - 1, y1 - 1, rad1, rad2);
        }
    }
}
