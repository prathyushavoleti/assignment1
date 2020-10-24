using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class codebehind : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void textbox1_TextChanged(object sender, EventArgs e)
    {
        string m = "Hello " + textbox1.Text + " welcome to dotnet training";
        Response.Write(m);
    }

    protected void btn1_Click(object sender, EventArgs e)
    {
        Response.Write("Programming is fun");
    }
}