using CSharpEgitimKampi601.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi601
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        string postgreConn = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres; Password=postgres";

        void GetAllCustomers()
        {
            var conn = new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "select * from Customers";
            var cmd=new NpgsqlCommand(query, conn);
            var adp = new NpgsqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        void GetCustomersById(int id)
        {
            var conn = new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "select * from Customers where CustomerId=@customerId";
            var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@customerId",id);
            cmd.ExecuteNonQuery();
            var adp = new NpgsqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            string customerName=txtCustomerName.Text;
            string customerCity=txtCustomerCity.Text;
            string customerSurname=txtCustomerSurname.Text;
            var conn=new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "insert into customers (CustomerName,CustomerSurname,CustomerCity) values " +
                "(@customerName,@customerSurname,@customerCity)";
            var cmd=new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@customerName", customerName);
            cmd.Parameters.AddWithValue("@customerSurname", customerSurname);
            cmd.Parameters.AddWithValue("@customerCity",customerCity);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı!");
            conn.Close();
            GetAllCustomers();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtCustomerId.Text);
            var conn = new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "Delete from customers where CustomerId=@customerId";
            var cmd= new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@customerId",id);
            cmd.ExecuteNonQuery ();
            MessageBox.Show("Silme işlemi başarılı!");
            conn.Close();
            GetAllCustomers();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            int id = int.Parse(txtCustomerId.Text);
            var conn = new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "update customers Set CustomerName=@customerName, CustomerSurname=@customerSurname," +
                "CustomerCity=@customerCity where CustomerId=@customerId";
            var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@customerId",id);
            cmd.Parameters.AddWithValue("@customerName",customerName);
            cmd.Parameters.AddWithValue("@customerSurname",customerSurname);
            cmd.Parameters.AddWithValue("@customerCity",customerCity);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı!");
            conn.Close();
            GetAllCustomers();
        }

        private void btnGetByCustomerId_Click(object sender, EventArgs e)
        {
            GetCustomersById(int.Parse(txtCustomerId.Text));
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
