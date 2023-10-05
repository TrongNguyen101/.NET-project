using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MemberObject member = memberRepository.GetMemberByEmail(txtEmail.Text);
            string userAdmin = "admin@fstore.com";
            string passAdmin = "admin@@";
            if (txtEmail.Text.Equals(userAdmin) && txtPassword.Text.Equals(passAdmin))
            {
                this.Hide();
                frmMemberManagements frmMemberManagement = new frmMemberManagements
                {
                    IsAdmin = true,
                    MemberInfor = null
                };
                if (frmMemberManagement.ShowDialog() == DialogResult.OK)
                {
                    source.Position = source.Count - 1;
                }
            }
            else if (member == null || !txtPassword.Text.Equals(member.Password))
            {
                MessageBox.Show("Log in failed");
            }
            else
            {
                this.Hide();
                frmMemberManagements frmMemberManagement = new frmMemberManagements
                {
                    IsAdmin = false,
                    MemberInfor = member
                };
                if (frmMemberManagement.ShowDialog() == DialogResult.OK)
                {
                    source.Position = source.Count - 1;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void cbShow_Change(object sender, EventArgs e)
        {
            if (cbShowPassWord.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
