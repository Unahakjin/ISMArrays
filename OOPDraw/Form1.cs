using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
            Bitmap canvas;
            public Form1()
            {
                InitializeComponent();
                canvas = new Bitmap(1920, 1080);
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void Button1_Click(object sender, EventArgs e)
            {
                Graphics g = Graphics.FromImage(canvas);
                //Graphics g = pictureBox1.CreateGraphics();
                ShapePoint[] shapes = new ShapePoint[10];
                Random randome = new Random();
                for (int i = 0; i < shapes.Length; i++)
                {
                    int q = randome.Next(1, 6);
                    switch (q)
                    {
                        case 1:
                            Dot dot = new Dot(Color.FromArgb(randome.Next(0, 256), randome.Next(0, 256), randome.Next(0, 256)),randome.Next(0,1920), randome.Next(0,1080));
                            dot.Draw(g);
                            pictureBox1.Image = canvas;
                            break;
                        case 2:
                            Line line = new Line(Color.FromArgb(randome.Next(0, 256), randome.Next(0, 256), randome.Next(0, 256)), randome.Next(0, pictureBox1.Width), randome.Next(0, pictureBox1.Height), randome.Next(0, pictureBox1.Width), randome.Next(0, pictureBox1.Height));
                            line.Draw(g);
                            pictureBox1.Image = canvas;
                            break;
                        case 3:
                        ClassLibrary.Rectangle rectangle = new ClassLibrary.Rectangle(Color.FromArgb(randome.Next(0, 256), randome.Next(0, 256), randome.Next(0, 256)), randome.Next(0, pictureBox1.Width), randome.Next(0, pictureBox1.Height), randome.Next(0, pictureBox1.Width/2), randome.Next(0, pictureBox1.Height/2));
                            rectangle.Draw(g);
                            pictureBox1.Image = canvas;
                            break;
                        case 4:
                            Circle circle = new Circle(Color.FromArgb(randome.Next(0, 256), randome.Next(0, 256), randome.Next(0, 256)), randome.Next(0, 1920), randome.Next(0, 1080),randome.Next(0,500));
                            circle.Draw(g);
                            pictureBox1.Image = canvas;
                            break;
                        case 5:
                            Ellipse ellipse = new Ellipse(Color.FromArgb(randome.Next(0, 256), randome.Next(0, 256), randome.Next(0, 256)), randome.Next(0, 1920), randome.Next(0, 1080), randome.Next(0, 500), randome.Next(0, 500));
                            ellipse.Draw(g);
                            pictureBox1.Image = canvas;
                            break;
                }
                }
            }

            private void Button2_Click(object sender, EventArgs e)
            {
                Graphics g = Graphics.FromImage(canvas);
                g.Clear(Color.White);
                pictureBox1.Image = canvas;
            }
    }
}
   
