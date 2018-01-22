using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NETWithCRUD
{
    public partial class frmMemberDB : Form
    {
        public frmMemberDB()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser addMember = new RegisterUser();
            addMember.ShowDialog();
            lstMembers.Items.Clear();
            PopulateListBox();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstMembers.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a member to delete!");
                return;
            }
            Member ToDelete = lstMembers.SelectedItem as Member;

            if (MemberDB.Delete(ToDelete))
            {
                MessageBox.Show("Member has been deleted!");
                lstMembers.Items.Clear();
                PopulateListBox();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstMembers.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a member to update!");
                return;
            }
            Member m = lstMembers.SelectedItem as Member;
            UpdateUser updateMember = new UpdateUser(m);
            updateMember.ShowDialog();
            lstMembers.Items.Clear();
            PopulateListBox();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberDB_Load(object sender, EventArgs e)
        {
            PopulateListBox();

        }

        private void PopulateListBox()
        {
            List<Member> memList = MemberDB.ListOfMembers();
            foreach (Member M in memList)
            {
                lstMembers.Items.Add(M);
            }
        }
    }
}


//        {
//            InitializeComponent();
//        }

//        private void button4_Click(object sender, EventArgs e)
//{
//    this.Close();
//}

//private void btnExit_Click(object sender, EventArgs e)
//{
//    this.Close();
//}

//private void btnDelete_Click(object sender, EventArgs e)
//{
//    //TODO: delete a hilighted user from list box. pop up form asking user
//    //if they are sure they would like to delete.
//    throw new NotImplementedException();
//}

//private void btnUpdate_Click(object sender, EventArgs e)
//{

//    //TODO: use grab user data from hilighted list box, pass it into this form.

//    UpdateUser UpUser = new UpdateUser();

//    UpUser.Show();
//}