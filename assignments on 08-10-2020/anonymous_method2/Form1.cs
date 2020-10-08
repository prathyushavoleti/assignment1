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
                 MessageBox.Show("today is thursday");
             };
            b.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("hello everyone");
            };

            //method creation
            //    private void button1_Click1(object sender1, EventArgs e1)
            //{
            //    MessageBox.Show("today is thursday");
            //}
        }
    }
}

