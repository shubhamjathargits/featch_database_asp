using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace login
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        MySqlConnection con;
        MySqlCommand cmd;
        string str;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection("Data Source=localhost;Database=login;UserID = root; Password = shubham");
            con.Open();
           
 string sQuery = "SELECT * from log";
            gd1.DataSource = getData(sQuery);
            gd1.DataBind();
        }
        private DataTable getData(string sQuery)
        {
            MySqlDataAdapter sdt = new MySqlDataAdapter();
            DataTable dTable = new DataTable();

            con = new MySqlConnection("Data Source=localhost;Database=login;UserID = root; Password = shubham");
        con.Open();
            MySqlCommand cmd = new MySqlCommand(sQuery, con);
            sdt.SelectCommand = cmd;
            sdt.Fill(dTable);
            con.Close();
            return dTable;
        }
    }
    }
