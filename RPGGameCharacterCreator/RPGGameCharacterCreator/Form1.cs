using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameCharacterCreator
{

    public partial class Form1 : Form
    {

        //GameCharacter[] Characters = new GameCharacter[10];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCharacter a = new CreateCharacter();
            a.ShowDialog();
            
        }

    }
}
