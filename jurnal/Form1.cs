using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jurnal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public jurnal j = new jurnal();
        int mdx = 0;
        int mdy = 0;
        int ismd = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            j.jurnale.Add(new Text());
            this.Controls.Add(new Text());
            this.Controls[Controls.Count - 1].Visible = true;
            this.Controls[Controls.Count - 1].Left = 100;
            this.Controls[Controls.Count - 1].Top =(Controls.Count * 105);

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                if (e.Y < mdy && Controls[2].Top <= 120)
                {
                    for (int i = 1; i < Controls.Count; i++)
                    {
                        if(Controls[i].GetType().Name == Controls[1].GetType().Name)
                        Controls[i].Top += (mdy - e.Y)/100;
                    }
                }
                if (e.Y > mdy && Controls[Controls.Count-1].Top > 120)
                {
                    for (int i = 1; i < Controls.Count; i++)
                    {
                        if (Controls[i].GetType().Name == Controls[1].GetType().Name)
                        Controls[i].Top -= (mdy + e.Y) / 100;
                    }
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
            mdx = e.X;
            mdy = e.Y;
        }
    }
}
