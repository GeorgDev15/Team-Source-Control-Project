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
    public partial class CreateCharacter : Form
    {

        public CreateCharacter()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {

            GameCharacter G = new GameCharacter();
            G.Name = txtCharacterName.Text;
            G.DEF = Convert.ToInt32(TxtDefense.Text);
            G.STR = Convert.ToInt32(TxtStrength.Text);
            G.VIT = Convert.ToInt32(TxtVitality.Text);
            //default should be at zero?
            G.XP = 0;
            this.Close();
        }

        /// <summary>
        /// Return a random integer from 5 to 10 to be placed into a character's stats
        /// </summary>
        /// <returns>an int that is random 5 to 10</returns>
        public int RandomStat()
        {
            Random RndStat = new Random();
            int StatToReturn = RndStat.Next(5, 11);
            return StatToReturn;
        }

        /// <summary>
        /// Sets vitality randomly from 25 to 40.
        /// </summary>
        /// <returns> random int 25 to 40</returns>
        public int RandomVitality()
        {
            Random RndVt = new Random();
            int VitToReturn = RndVt.Next(25, 41);
            return VitToReturn;
        }


        private void BtnRandom_Click(object sender, EventArgs e)
        {
            TxtDefense.Text = Convert.ToString(RandomStat());
            TxtStrength.Text = Convert.ToString(RandomStat());
            TxtVitality.Text = Convert.ToString(RandomVitality());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddVIT_Click(object sender, EventArgs e)
        {
            PlusVitality();

        }

        private void PlusVitality()
        {
            if (!string.IsNullOrWhiteSpace(TxtVitality.Text))
            {
                int Vitality = Convert.ToInt32(TxtVitality.Text);
                Vitality += 1;
                TxtVitality.Text = Convert.ToString(Vitality);

            }
            else
            {
                MessageBox.Show("There needs to be a value in here.");
            }
        }
    }
}
