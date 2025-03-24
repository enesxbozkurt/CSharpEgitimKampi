using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db= new FinancialCrmEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            this.Hide();
            frm.ShowDialog();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            var categories = db.Categories.ToList();
            dataGridView1.DataSource = categories;
        }
    }
}
