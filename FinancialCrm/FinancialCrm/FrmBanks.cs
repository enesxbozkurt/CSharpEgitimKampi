using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db= new FinancialCrmEntities();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //Banka Bakiyeleri
            var tebBalance=db.Banks.Where(x=>x.BankTitle=="Teb").Select(y=>y.BankBalance).FirstOrDefault();
            var yapikrediBalance=db.Banks.Where(x=>x.BankTitle== "Yapıkredi").Select(y=>y.BankBalance).FirstOrDefault();
            var garantiBalance=db.Banks.Where(x=>x.BankTitle== "Garanti").Select(y=>y.BankBalance).FirstOrDefault();

            lblTebBankBalance.Text = tebBalance.ToString() + " ₺";
            lblYapikrediBalance.Text = yapikrediBalance.ToString() + " ₺";
            lblGarantiBalance.Text = garantiBalance.ToString() + " ₺";

            //Banka Hareketleri
            var bankProcess1=db.BankProcesses.OrderByDescending(x=>x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text=bankProcess1.Description +" - "+ bankProcess1.Amount +" - "+ bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " - " + bankProcess2.Amount + " - " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " - " + bankProcess3.Amount + " - " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " - " + bankProcess4.Amount + " - " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " - " + bankProcess5.Amount + " - " + bankProcess5.ProcessDate;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmDashboard frm= new FrmDashboard();
            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            this.Hide();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            this.Hide();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            this.Hide();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            this.Hide();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
