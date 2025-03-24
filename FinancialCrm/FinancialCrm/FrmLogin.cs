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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmEntities db=new FinancialCrmEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            var user = db.Users
             .Where(x => x.Username == txtUsername.Text)
             .FirstOrDefault();

           
            if (user != null)
            {
                
                if (user.Password == txtPassword.Text)
                {
                    FrmDashboard frm = new FrmDashboard();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı şifre! Lütfen tekrar deneyiniz.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı! Lütfen tekrar deneyiniz.");
            }
        }
    }
}
