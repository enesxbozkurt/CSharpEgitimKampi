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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db = new FinancialCrmEntities();


        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var spendings = db.Spendings.ToList();
            dataGridView1.DataSource = spendings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
