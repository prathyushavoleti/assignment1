using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace commands
{
    public partial class postbackurl : System.Web.UI.Page
    {
       

        protected void linkbutton1_Click(object sender, EventArgs e)
        {
            label1.Text = "programming is fun";
        }
    }
}