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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser RegUser = new RegisterUser();

            RegUser.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //TODO: delete a hilighted user from list box. pop up form asking user
            //if they are sure they would like to delete.
            throw new NotImplementedException();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //TODO: use grab user data from hilighted list box, pass it into this form.

            UpdateUser UpUser = new UpdateUser();

            UpUser.Show();
        }
    }
}
