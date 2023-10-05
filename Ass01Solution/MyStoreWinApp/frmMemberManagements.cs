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
using System.Xml.Linq;

namespace MyStoreWinApp
{
    public partial class frmMemberManagements : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmMemberManagements()
        {
            InitializeComponent();
        }

        BindingSource source;

        public Boolean IsAdmin { get; set; }
        public MemberObject MemberInfor { get; set; }
        private void frmMemberManagements_Load(object sender, EventArgs e)
        {
            if (IsAdmin == false)
            {
                txtMemberID.Text = MemberInfor.MemberID.ToString();
                txtMemberName.Text = MemberInfor.MemberName;
                txtPassword.Text = MemberInfor.Password;
                txtCity.Text = MemberInfor.City;
                txtCountry.Text = MemberInfor.Country;
                txtEmail.Text = MemberInfor.Email;
                btnDelete.Visible = false;
                btnNew.Visible = false;
                dgvMember.Visible = false;
                txtMemberID.Enabled = false;
                this.Size = new Size(637, 212);
            }
            else
            {
                ClearText();
                LoadMemberList();
                dgvMember.CellDoubleClick += dgvMember_CellDoubleClick;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add New Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Position - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject memberObject = GetMemberObject();
                memberRepository.UpdateMember(memberObject);
                LoadMemberList();
                MessageBox.Show("Update sucessfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Member");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to delete this member?",
                           "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    var member = GetMemberObject();
                    memberRepository.DeleteMember(member.MemberID);

                    LoadMemberList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Remove Member");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin
            {

            };
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {

                source.Position = source.Count - 1;
            }
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public MemberObject GetMemberObject()
        {
            MemberObject obj = null;
            try
            {
                obj = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return obj;
        }

        public void LoadMemberList()
        {
            var list = memberRepository.GetMemberList();
            try
            {
                source = new BindingSource();
                source.DataSource = list;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
                if (list.Count() == 0)
                {
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member");
            }
        }

        public void ClearText()
        {
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void rbtnSortByID_CheckedChanged(object sender, EventArgs e)
        {
            memberRepository.SortMemberByID();
            LoadMemberList();
        }

        private void rbtnSortByName_CheckedChanged(object sender, EventArgs e)
        {
            memberRepository.SortMemberByName();
            LoadMemberList();
        }
    }
}
