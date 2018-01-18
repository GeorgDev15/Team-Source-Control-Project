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
    public partial class UpdateUser : Form
    {
        private Member currMem;
        public UpdateUser(Member m)
        {
            InitializeComponent();
            currMem = m;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            txtFName.Text = currMem.FirstName;
            txtLName.Text = currMem.LastName;
            dtpDate.Value = currMem.BirthDate;
            txtFaveAnimal.Text = currMem.FavoriteAnimal;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            currMem.FirstName = txtFName.Text;
            currMem.LastName = txtLName.Text;
            currMem.BirthDate = dtpDate.Value;

            if(MemberDB.Update(currMem))
            {
                MessageBox.Show("Member updated!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong..." + "\nPlease check your info.");
                return;
            }
        }
    }
}
