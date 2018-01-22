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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
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
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberDB_Load(object sender, EventArgs e)
        {
            //On load access database to populate listbox.
            SqlCommand retrieve = new SqlCommand();
            retrieve.Connection = DBHelper.GetConnection();
            retrieve.CommandText = "SELECT  MemberID, FirstName, LastName, BirthDate, FavoriteAnimal FROM Member";
            

            try
            {

                retrieve.Connection.Open();
                SqlDataReader reader = retrieve.ExecuteReader();

                var MemberList = new List<Member>();
                while (reader.Read())
                {

                    var Members = new Member();
                    Members.MemberID = (int)reader["MemberID"];
                    Members.BirthDate = (DateTime)reader["BirthDate"];
                    Members.FirstName = (String)reader["FirstName"];
                    Members.LastName = (String)reader["LastName"];
                    Members.FavoriteAnimal = (String)reader["FavoriteAnimal"];
                    MemberList.Add(Members);

                    
                    lstMembers.Items.Add(Members);

                }

                

                



                
            } finally

            {
                retrieve.Connection.Dispose();
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