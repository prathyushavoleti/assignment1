using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString1
{
    public partial class querystring1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "Haritha" && TextBox2.Text == "Yelleti")
            {
                Response.Redirect("Homepage1.aspx?name= " + TextBox1.Text + "&pwd " + TextBox2.Text);
                Response.Write("Login Successful");
            }
           if(TextBox1.Text == "Firdos" && TextBox2.Text == "Shaik")
            {
                Response.Redirect("Homepage1.aspx?name= " + TextBox1.Text + "&pwd " + TextBox2.Text);
                Response.Write("Login Successful");
            }
            if (TextBox1.Text == "prathyusha" && TextBox2.Text == "prathyusha@123")
            {
                Response.Redirect("Homepage1.aspx?name= " + TextBox1.Text + "&pwd " + TextBox2.Text);
                Response.Write("Login Successful");
            }
            if (TextBox1.Text == "Ramya" && TextBox2.Text == "Sarvasiddi")
            {
                Response.Redirect("Homepage1.aspx?name= " + TextBox1.Text + "&pwd " + TextBox2.Text);
                Response.Write("Login Successful");
            }
            if (TextBox1.Text == "Sravani" && TextBox2.Text == "Savithini")
            {
                Response.Redirect("Homepage1.aspx?name= " + TextBox1.Text + "&pwd " + TextBox2.Text);
                Response.Write("Login Successful");
            }


            Label3.Text = "invalid user";
        }
    }
}