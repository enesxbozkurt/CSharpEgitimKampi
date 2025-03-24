using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;


namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db=new FinancialCrmEntities();

        SqlConnection conn = new SqlConnection("Server=SL11B97077\\SQLEXPRESS03; Database=FinancialCrm; Integrated Security=True;");

        private void button2_Click(object sender, EventArgs e)
        {
            var users = db.Users.ToList();
            dataGridView1.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            conn.Open();
            string query = "insert into Users (Username,Password) values " +
                "(@username,@password)";
            var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı!");
            conn.Close();
            var users = db.Users.ToList();
            dataGridView1.DataSource = users;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            this.Hide();
            frm.ShowDialog();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
