using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace studentdatabound
{
    public partial class studentdatabound : System.Web.UI.Page
    {
        

            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["studentdetails"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
                {
                    Bind();
                }
            }
            public void Bind()
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select * from studentdetails", connect);
                SqlDataAdapter sd = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                sd.Fill(ds, "studentdetails");
                rpr1.DataSource = ds.Tables[0];
                rpr1.DataBind();
                connect.Close();//sql server connection closed
            }



        }
    }
    
