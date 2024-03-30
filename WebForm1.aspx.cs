using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String Firstname;
            String Lastname;
            String Username;
            String Gender;
            String Password;
            String Email;
            String Phone;
            String Adress;
            String Age;
            //String Languages;
            String Country = DropDownList1.SelectedValue;
            Firstname =TextBox1.Text;
            Lastname = TextBox2.Text;
            Username = TextBox3.Text;
            Gender = RadioButton1.Text;
            Password = TextBox5.Text;
            Email = TextBox6.Text;
            Phone = TextBox7.Text;
            Adress = TextBox8.Text;
            Age = TextBox9.Text;
            String Languages = Label11.Text;
            if(CheckBox1.Checked == true)
            {
                Languages = CheckBox1.Text + ",";
            }
            if (CheckBox2.Checked == true)
            {
                Languages = CheckBox2.Text + ",";
            }
            if (CheckBox3.Checked == true)
            {
                Languages = CheckBox3.Text + ",";
            }

            SqlConnection con = new SqlConnection("data source=DESKTOP-OAU1L08\\MSSQLSERVER1;database=Puli.ntr;integrated security =yes");

            con.Open();

            string query = "insert into Regestration values('" + Firstname+"','"+Lastname+"','"+Username+"','"+Gender+"','"+Password+"','"+Email+"','"+Phone+"','"+Adress+"','"+Age+"','"+Languages+"','"+Country+"')";


            SqlCommand cmd =new SqlCommand(query, con);


        cmd.ExecuteNonQuery();

            con.Close();


            

            Response.Redirect("WebForm2.aspx");

        }
    }
}