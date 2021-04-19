using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Timers;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;

        }
        public void ImageBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                button2.Location = new Point(button2.Location.X - 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X - 10, button1.Location.Y);
            }

            else if (e.KeyCode == Keys.Right)
            {
                button2.Location = new Point(button2.Location.X + 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.Space)
            {
                button2.Visible = true;
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                button2.Location = new Point(button2.Location.X - 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X - 10, button1.Location.Y);
            }
            else if (e.KeyCode == Keys.Right)
            {
                button2.Location = new Point(button2.Location.X + 10, button2.Location.Y);
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
            else if(e.KeyCode==Keys.Space)
            {
                button2.Visible = false;
            }
        }

        Button button;
        public void timer1_Tick(object sender, EventArgs e)
        {
            
            Random r = new Random();
            button = new Button();
            button.Location = new Point(r.Next(16, 760), 0);
            button.BackgroundImage = WinFormsApp1.Properties.Resources.Meteor;
            button.BackgroundImageLayout = ImageLayout.Zoom;

        }     

       public void timer2_Tick(object sender, EventArgs e)
        {
            
        }
    }
}


