using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MySql.Data.MySqlClient;

namespace login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string str;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Data Source=localhost;Database=login;UserID = root; Password = shubham");
            con.Open();
            Response.Write("connect");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            str = "insert into log values ('" + TextBox1.Text.ToString() + "','"
            + TextBox2.Text + "')";
            cmd = new MySqlCommand(str, con);
            cmd.ExecuteNonQuery();
            Response.Redirect("webform2.aspx");

        }
    }
}