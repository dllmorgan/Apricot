using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApricotEditor
{
    public partial class Editor : Form
    {
        private Map map;        

        public Editor()
        {
            InitializeComponent();
        }

        private void mainView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            for (int x = 0; x < this.Width; x = x + 20)
            {
                e.Graphics.DrawLine(Pens.Gray, x, 0, x, this.Height);
            }

            for (int y = 0; y < this.Height; y = y + 20)
            {
                e.Graphics.DrawLine(Pens.Gray, 0, y, this.Width, y );
            }

        }

        private void mainView_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = e.Location.ToString();
            var x = e.Location.X / 20;
            textBox4.Text = "X = " + x + ": Y = " + e.Location.Y;
        }

        private void zoomView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainView_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.Location.ToString();
            textBox3.Text = e.Location.ToString();
        }

    }
}
