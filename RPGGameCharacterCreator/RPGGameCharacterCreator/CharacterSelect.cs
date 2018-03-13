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
        //amount of points allowed to allocate to stats.
        int AllocationLimit = 10;

        //amount of times the user is allowed to randomize stats of a character.
        int RandomizeLimit = 5;


        public CreateCharacter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// validates for empty name or stat boxes and if successful,
        /// adds a character to the characters array in the main form. Database functionality
        /// needs to be added still.
        /// </summary>
        
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCharacterName.Text) && !string.IsNullOrWhiteSpace(TxtDefense.Text)
                    && !string.IsNullOrWhiteSpace(TxtStrength.Text) && !string.IsNullOrWhiteSpace(TxtVitality.Text))
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
            else
            {
                MessageBox.Show("You need to give your character a name or you failed to roll stats.");
            }

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

        /// <summary>
        /// randomize the three stats of the character. Can only be done 5 times.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRandom_Click(object sender, EventArgs e)
        {
            if (RandomizeLimit != 0)
            {

                TxtDefense.Text = Convert.ToString(RandomStat());
                TxtStrength.Text = Convert.ToString(RandomStat());
                TxtVitality.Text = Convert.ToString(RandomVitality());
                RandomizeLimit -= 1;
                LblRandomAlottment.Text = Convert.ToString(RandomizeLimit);

                //reset allocated points when randomizing.
                AllocationLimit = 10;
                LblAllocation.Text = Convert.ToString(AllocationLimit);
            }
            else
                MessageBox.Show("You've reached the limit of times you can randomize stats.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddVIT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtVitality.Text))
            {
                if (AllocationLimiter())
                {
                    PlusVitality();
                }
                else
                    MessageBox.Show("All points have been used.");
            }

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

        private void BtnAddSTR_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtStrength.Text))
            {
                if (AllocationLimiter())
                {
                    AddStrength();
                }
                else
                    MessageBox.Show("All points have been used.");
            }
        }

        private void AddStrength()
        {
            if (!string.IsNullOrWhiteSpace(TxtStrength.Text))
            {
                int Strength = Convert.ToInt32(TxtStrength.Text);
                Strength += 1;
                TxtStrength.Text = Convert.ToString(Strength);
            }
            else
            {
                MessageBox.Show("There needs to be a value in here.");
            }
        }

        /// <summary>
        /// Subtracts from the allocation points to ensure users don't
        /// go over the limit.
        /// </summary>
        /// <returns> true if there are still points left to allocate, and false if not.</returns>
        public bool AllocationLimiter()
        {
            if (AllocationLimit != 0)
            {
                AllocationLimit -= 1;
                LblAllocation.Text = Convert.ToString(AllocationLimit);
                return true;
            }
            else return false;

        }

        /// <summary>
        /// Clears out all text boxes and returns limits to their original state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCharacterName.Clear();
            TxtDefense.Clear();
            TxtStrength.Clear();
            TxtVitality.Clear();
            AllocationLimit = 10;
            RandomizeLimit = 5;
            LblAllocation.Text = Convert.ToString(AllocationLimit);
            LblRandomAlottment.Text = Convert.ToString(RandomizeLimit);
        }

        private void BtnAddDEF_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtDefense.Text))
            {
                if (AllocationLimiter())
                {
                    AddDef();
                }
                else
                    MessageBox.Show("All points have been used.");
            }
        }

        private void AddDef()
        {
            if (!string.IsNullOrWhiteSpace(TxtDefense.Text))
            {
                int Defense = Convert.ToInt32(TxtDefense.Text);
                Defense += 1;
                TxtDefense.Text = Convert.ToString(Defense);
            }
            else
            {
                MessageBox.Show("There needs to be a value in here.");
            }
        }

        private void CreateCharacter_Load(object sender, EventArgs e)
        {
            TxtDefense.Text = Convert.ToString(RandomStat());
            TxtStrength.Text = Convert.ToString(RandomStat());
            TxtVitality.Text = Convert.ToString(RandomVitality());
        }
    }
}
