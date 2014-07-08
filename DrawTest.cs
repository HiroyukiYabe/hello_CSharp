using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFrmApp
{
    public class MyForm : Form
    {

        private Button btn;

        public MyForm()
        {
            this.Width = 300;
            this.Height = 200;
            this.Paint += myframe_paint;

            btn = new Button();
            btn.Text = "click";
            btn.Height = 30;
            btn.Width = 100;
            btn.Top = 200;
            btn.Left = 100;
            btn.Click += btn_Click;
            this.Controls.Add(btn);
        }

        private void myframe_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red);
            Brush b = new SolidBrush(Color.Blue);
            g.FillRectangle(b,50,50,50,50);
            g.DrawEllipse(p,75,75,50,50);
        }

        private void myframe_paint_click(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image img = Image.FromFile("IMG_1533.JPG");
            g.DrawImage(img,25,25,100,100);
            g.DrawImage(img,125,125,100,100);
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            this.Paint += myframe_paint_click;
        }

    }
}