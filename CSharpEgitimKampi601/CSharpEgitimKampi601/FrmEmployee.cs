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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            GetAllDepartments();
        }

        string postgreConn = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres; Password=postgres";

        void GetAllEmployees()
        {
            var conn = new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "select * from Employees";
            var cmd = new NpgsqlCommand(query, conn);
            var adp = new NpgsqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conn.Close();
        }

        void GetAllDepartments()
        {
            var conn = new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "select * from Departments";
            var cmd = new NpgsqlCommand(query, conn);
            var adp = new NpgsqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeeDepartment.ValueMember = "DepartmentId";
            cmbEmployeeDepartment.DataSource = dataTable;
            conn.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetAllEmployees();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string EmployeeName = txtEmployeeName.Text;
            string EmployeeSurname = txtEmployeeSurname.Text;
            decimal EmployeeSalary = decimal.Parse(txtEmployeeSalary.Text);
            int DepartmentId = int.Parse(cmbEmployeeDepartment.SelectedValue.ToString());
            var conn = new NpgsqlConnection(postgreConn);
            conn.Open();
            string query = "insert into Employees (EmployeeName,EmployeeSurname,EmployeeSalary,DepartmentId) values " +
                "(@employeeName,@employeeSurname,@employeeSalary,@departmentId)";
            var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@employeeName", EmployeeName);
            cmd.Parameters.AddWithValue("@employeeSurname", EmployeeSurname);
            cmd.Parameters.AddWithValue("@employeeSalary", EmployeeSalary);
            cmd.Parameters.AddWithValue("@departmentId", DepartmentId);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı!");
            conn.Close();
            GetAllEmployees();
        }
    }
}
