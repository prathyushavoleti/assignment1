using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace commands
{
    public partial class oncommand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void linkbtn1_Command(object sender, CommandEventArgs e)
        {
            label1.Text = "you chose " + e.CommandName + " item " + e.CommandArgument;

        }

        protected void linkbtn2_Command(object sender, CommandEventArgs e)
        {
            label1.Text = "you chose " + e.CommandName + " item " + e.CommandArgument;
        }
    }
}