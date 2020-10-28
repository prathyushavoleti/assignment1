using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Datagrid
{
    public partial class datagrid1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection("data source=.;database=student;integrated security=SSPI"))
            {
                SqlDataAdapter sd = new SqlDataAdapter("select * from student", connect);//to retrieve the data from the database from the employee created 
                SqlDataAdapter sd1 = new SqlDataAdapter("select * from employees", connect);//to retrieve the data from the database from the employee created 
                SqlDataAdapter sd2 = new SqlDataAdapter("select * from IndianCricketTeam", connect);//to retrieve the data from the database from the employee created 
                SqlDataAdapter sd3 = new SqlDataAdapter("select * from IndianRailwaySystem", connect);//to retrieve the data from the database from the employee created 
                SqlDataAdapter sd4 = new SqlDataAdapter("select * from Bank", connect);//to retrieve the data from the database from the employee created 

                DataSet ds = new DataSet();//to convert the data into the grid.
                sd.Fill(ds);
                datagrid.DataSource = ds;
                datagrid.DataBind();


               


                DataSet ds2 = new DataSet();//to convert the data into the grid.
                sd1.Fill(ds2);
                datagrid2.DataSource = ds2;
                datagrid2.DataBind();


                DataSet ds3 = new DataSet();//to convert the data into the grid.
                sd2.Fill(ds3);
                datagrid3.DataSource = ds3;
                datagrid3.DataBind();

                DataSet ds4 = new DataSet();//to convert the data into the grid.
                sd3.Fill(ds4);
                datagrid4.DataSource = ds4;
                datagrid4.DataBind();

                DataSet ds5 = new DataSet();//to convert the data into the grid.
                sd4.Fill(ds5);
                datagrid5.DataSource = ds5;
                datagrid5.DataBind();
            }
                
                
        }

        
    }
}