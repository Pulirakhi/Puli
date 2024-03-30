using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Username;
            String Roomtype;
            string Amenities;
            Username = TextBox2.Text;
            string roomtype;
            String amenities = "";
            if (RadioButton1.Checked == true)
            {
                roomtype=RadioButton1.Text;
            }
            else
            {
                roomtype=RadioButton2.Text;
            }
            if(CheckBox1.Checked == true)
            {
                amenities=CheckBox1.Text;
            }
            if(CheckBox2.Checked == true)
            {
                amenities =CheckBox2.Text;
            }

            SqlConnection con = new SqlConnection("data source=DESKTOP-OAU1L08\\MSSQLSERVER1;database=Puli.ntr;integrated security =yes");
            con.Open();

            string query = "insert into Hotel2 values('" + Username+ "','" + roomtype + "','" + amenities + "')";


            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();

            con.Close();


            Response.Redirect("WebForm6.aspx");
        }
    }
}