using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=DESKTOP-OAU1L08\\MSSQLSERVER1;database=Puli.ntr;integrated security =yes");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from  Hotel2", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds.Tables[0];    
            GridView1.DataBind();
        }
    }
}