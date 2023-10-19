using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace StormWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label1.Text = ("Snyggt jobbat");
            }
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection stormconn = new SqlConnection("Server=tcp:testlabb-server.database.windows.net,1433;Initial Catalog=testlabb-database;Persist Security Info=False;User ID=testlabb-server-admin;Password=Lernia202020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertFullname @fullname", stormconn);
                insert.Parameters.AddWithValue("@fullname", TextBox1.Text);

                stormconn.Open();
                insert.ExecuteNonQuery();
                stormconn.Close();

                if (IsPostBack)
                {
                    TextBox1.Text = "";
                }
            }
        }
    }
}