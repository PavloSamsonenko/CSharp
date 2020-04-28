using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CSharp_Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.Brown);
            pen1.Width = 3;
            pen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            HatchBrush brush1 = new HatchBrush(HatchStyle.Divot, Color.DarkBlue);
            Graphics g = Graphics.FromHwnd(this.Handle);
            g.DrawRectangle(pen1, 50, 50, 150, 100);
            Brush brush2 = Brushes.Pink;
            string s = "Hi world!";
            Font myFont = new Font("ArialBlack", 14);
            g.DrawString(s, myFont, brush2, 60, 60);
            g.FillEllipse(brush1, 100, 150, 210, 150);

        }
    }
}
