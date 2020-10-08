using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anonymousmethod_win1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "click here";
            b.Size = new Size(100, 50);
            b.Location = new Point(650, 300);
            this.Controls.Add(b);
            b.Click += new EventHandler(button1_Click1);
            b.Click += new EventHandler(button1_Click2);
            b.Click += new EventHandler(button1_Click3);
            b.Click += new EventHandler(button1_Click4);
            b.Click += new EventHandler(button1_Click5);
            b.Click += new EventHandler(button1_Click6);
        }
        private void button1_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
        private void button1_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("programming is fun");
        }
        private void button1_Click3(object sender, EventArgs e)
        {
            MessageBox.Show("this is printing");
        }
        private void button1_Click4(object sender, EventArgs e)
        {
            MessageBox.Show("this is printing again");
        }
        private void button1_Click5(object sender, EventArgs e)
        {
            MessageBox.Show("Yeyy! this is crazy");
        }
        private void button1_Click6(object sender, EventArgs e)
        {
            MessageBox.Show("Yeyy! this is printing crazy");
        }


        //    Button b = new Button();
        //b.Text = "click here";
        //b.Size = new Size(100, 50);
        //b.Location = new Point(650, 300);
        //this.Controls.Add(b);

    }
    }

