using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Operation
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Response.Write("Page_Load      <br/>");

            if (!IsPostBack)
            {
                DataLoad();
            }

            // DataLoad();



        }

        void DataLoad()
        {
            string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;";
            SqlConnection con = new SqlConnection(ConnectionString);

            string cmdText = "Select * from Product";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        Product p = new Product();
            //        p.Id = (int) reader["Id"];
            //        p.Name = reader["Name"].ToString();
            //        p.Price = (int)reader["Price"];

            //    }
            //}




            gvProduct.DataSource = reader;
            gvProduct.DataBind();

            con.Close();

        }



        protected void Page_Init(object sender, EventArgs e)
        {
           // Response.Write("Page_Init    <br/>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
           // Response.Write("Page_PreRender     <br/>");
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {

            //to read information from textbox
            int Id = int.Parse(txtId.Text);
            string Name = txtName.Text;
            int Price = int.Parse(txtPrice.Text);


            string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;";
            SqlConnection con = new SqlConnection(ConnectionString);

            string cmdText = $"Insert into Product values ( {Id}, '{Name}', {Price} )";
            SqlCommand cmd = new SqlCommand(cmdText, con);

            con.Open();
            int reader = cmd.ExecuteNonQuery();

             

            if (reader > 0)
            {
                lblMessage.Text = "Product Inserted Successfully";
            }
            else
            {
                lblMessage.Text = "Product Not Inserted ";
            }

           
            con.Close();


            DataLoad();



        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);
            string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;";
            SqlConnection con = new SqlConnection(ConnectionString);

            string cmdText = $"Select Name, Price from Product where @Id=Id";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@Id", Id);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtName.Text = reader["Name"].ToString();
                txtPrice.Text = reader["Price"].ToString();
            }

            DataLoad();


           


             con.Close();



        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);
            string Name = txtName.Text;
            int Price = int.Parse(txtPrice.Text);


            string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;";
            SqlConnection con = new SqlConnection(ConnectionString);

            string cmdText = $"Update Product set Name=@Name, Price=@Price where Id=@Id";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Price", Price);


            con.Open();
            int reader = cmd.ExecuteNonQuery();

            if (reader > 0)
            {
                lblMessage.Text = "Product Updated Successfully";
            }
            else
            {
                lblMessage.Text = "Product Not Updated ";
            }



            DataLoad();

            con.Close();



        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        void ClearForm()
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtId.Text);
           // string Name = txtName.Text;
           // int Price = int.Parse(txtPrice.Text);


            string ConnectionString = "server=.\\sqlexpress;database=B22ADONETDB;integrated security=true;";
            SqlConnection con = new SqlConnection(ConnectionString);

            string cmdText = $"Delete Product where Id=@Id";
            SqlCommand cmd = new SqlCommand(cmdText, con);
            cmd.Parameters.AddWithValue("@Id", Id);
            //cmd.Parameters.AddWithValue("@Name", Name);
           // cmd.Parameters.AddWithValue("@Price", Price);


            con.Open();
            int reader = cmd.ExecuteNonQuery();

            if (reader > 0)
            {
                lblMessage.Text = "Product Deleted Successfully";
            }
            else
            {
                lblMessage.Text = "Product Not Deleted ";
            }



            DataLoad();

            con.Close();

        }


    }
}