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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var mem = new Member();
            mem.FirstName = txtFName.Text;
            mem.LastName = txtLName.Text;
            mem.FavoriteAnimal = txtFaveAnimal.Text;
            mem.BirthDate = dtpDate.Value;

            if (MemberDB.Add(mem))
            {
                MessageBox.Show("Member added!");
            }
            else
            {
                MessageBox.Show("Uh oh, something went wrong!" + "\nPlease try again.");
            }
        }
    }
}
