using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db= new FinancialCrmEntities();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title=txtBillTitle.Text;
            decimal amount=decimal.Parse(txtBillAmount.Text);
            string period=txtBillPeriod.Text;

            Bill bills= new Bill();
            bills.BillTitle=title;
            bills.BillAmount=amount;
            bills.BillPeriod=period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarıyla Eklendi!","Ödemeler",MessageBoxButtons.OK,MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtBillId.Text);
            var removeValue=db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarıyla Silindi!", "Ödemeler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;
            var values=db.Bills.Find(id);
            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarıyla Güncellendi!", "Ödemeler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
           FrmDashboard frm = new FrmDashboard();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmSpendings frm=new FrmSpendings();
            this.Hide();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmDashboard frm=new FrmDashboard();
            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm=new FrmCategories();
            this.Hide();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm=new FrmBankTransactions();
            this.Hide();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSettings frm=new FrmSettings();
            this.Hide();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
