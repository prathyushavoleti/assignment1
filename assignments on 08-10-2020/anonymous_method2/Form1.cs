using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anonymous_methodwin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();//reference to the button
            b.Text = "click here";//text implemented on the button appearance
            b.Size = new Size(100, 50);//size maintained for the button
            b.Location = new Point(650, 300);//pointer location of button
            this.Controls.Add(b);//controlling mechanism of button shld go center
                                 //instantiating the event handler
                                 //show the message
                                 //b.Click += new EventHandler(button1_Click1);
            b.Click += delegate (object sender1, EventArgs e1)
             {
                 MessageBox.Show("Hello World");
             };
            b.Click += delegate (object sender2, EventArgs e2)
            {
                MessageBox.Show("Programming is Fun");
            };
            b.Click += delegate (object sender3, EventArgs e3)
            {
                MessageBox.Show("This is printing");
            };
            b.Click += delegate (object sender4, EventArgs e4)
            {
                MessageBox.Show("this is printing again");
            };
            b.Click += delegate (object sender5, EventArgs e5)
            {
                MessageBox.Show("Yeyy! this is crazy");
            };
            b.Click += delegate (object sender6, EventArgs e6)
            {
                MessageBox.Show("Yeyy! this is printing crazy");
            };

            //method creation
            //    private void button1_Click1(object sender1, EventArgs e1)
            //{
            //    MessageBox.Show("today is thursday");
            //}
        }
    }
}

