using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Radiobutton : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        
        Response.Write("This is red");
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is blue");
    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        Response.Write("This is green");
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        colorid.Text = " ";
        if (RadioButton1.Checked)
            colorid.Text = "the color is " + RadioButton1.Text;
        else if(RadioButton2.Checked)
            colorid.Text = "the color is " + RadioButton2.Text;
        else
            colorid.Text = "the color is " + RadioButton3.Text;

    }
}