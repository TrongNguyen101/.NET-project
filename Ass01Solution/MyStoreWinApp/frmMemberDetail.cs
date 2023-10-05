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
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate {  get; set; }
        public MemberObject Member { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(member);
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, InsertOrUpdate==false ? "Add a new car" : "Update a Car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtMemberID.Text = Member.MemberID.ToString();
                txtMemberName.Text = Member.MemberName.ToString();
                txtEmail.Text = Member.Email.ToString();
                txtPassword.Text = Member.Password.ToString();
                txtCity.Text = Member.City.ToString();
                txtCountry.Text = Member.Country.ToString();
            }
        }
    }
}
