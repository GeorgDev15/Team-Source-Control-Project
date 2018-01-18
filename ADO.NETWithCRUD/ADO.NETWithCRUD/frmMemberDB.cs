using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //TODO: Add a method that populates listbox
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TODO: Add a method that populates listbox
            //TODO: Add a method that deletes selected item in listbox
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lstMembers.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a member to update!");
                return;
            }
            Member m = lstMembers.SelectedItem as Member;
            UpdateUser updateMember = new UpdateUser(m);
            updateMember.ShowDialog();
            //TODO: Add a method that populates listbox
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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