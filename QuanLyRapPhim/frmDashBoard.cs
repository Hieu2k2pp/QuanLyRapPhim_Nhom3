using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
        }
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        void ChangeAccount(int type)
        {
            if (loginAccount.Type == 2) btnAdmin.Enabled = false;
            lblAccountInfo.Text += LoginAccount.UserName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminNewDesign frm = new frmAdminNewDesign();
            frm.ShowDialog();
            this.Show();
        }

        private void BtnSeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeller frm = new frmSeller();
            frm.ShowDialog();
            this.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmAccountSettings frm = new frmAccountSettings(loginAccount);
            frm.ShowDialog();
            this.Show();
        }
    }
}
