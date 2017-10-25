using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> p = new List<Point>();
        bool paint = false;
        Point[] point;
        SolidBrush brush = new SolidBrush(Color.Bisque);
        PointF[] pointF;
        Pen pen = new Pen(new SolidBrush(Color.Chocolate));
        Color color;
        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            g.Clear(panel1.BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            p.Add(new Point(e.X, e.Y));
            Graphics m = panel1.CreateGraphics();
            m.FillEllipse(brush, e.X, e.Y, 1, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics m = panel1.CreateGraphics();
            p.Add(p.First());
            point = p.GetRange(0, p.Count).ToArray();
            try
            {
                m.FillPolygon(brush, point); 
                m.DrawLines(pen, point);
                m.Dispose();
            }
            catch { }
            p.Clear();
        }

       
    }
         
}
