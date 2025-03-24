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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db=new FinancialCrmEntities();
        int count = 0;

        public static class FrmTools
        {
            public static void GeriDon(Form currentForm)
            {
                FrmDashboard frm = new FrmDashboard();
                currentForm.Hide();
                frm.ShowDialog();
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString()+" ₺";

            //Chart1
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach(var item in bankData)
            {
                series.Points.AddXY(item.BankTitle,item.BankBalance);
            }

            //Chart2
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach(var item in billData)
            {
                series2.Points.AddXY(item.BillTitle,item.BillAmount);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count ++;
            if (count%10==1)
            {
                var telefonFaturasi = db.Bills.Where(x => x.BillTitle == "Telefon Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text ="Telefon Faturası";
                lblBillAmount.Text=telefonFaturasi.ToString()+" ₺";

                var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
                lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + " ₺";
            }
            if (count % 10 == 4)
            {
                var telefonFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = telefonFaturasi.ToString()+" ₺";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSettings frm= new FrmSettings();
            this.Hide();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm= new FrmBankTransactions();
            this.Hide();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            this.Hide();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            this.Hide();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            this.Hide();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
