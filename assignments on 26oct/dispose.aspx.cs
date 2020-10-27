using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace commands
{
    public partial class dispose : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkbutton1_Disposed(object sender, EventArgs e)
        {
            Label1.Text = "Training on .Net course";
        }
    }
}