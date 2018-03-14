using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameCharacterCreator
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCharacter a = new CreateCharacter();
            a.ShowDialog();

        }

        //placeholder fighters to develop and test how fights will work.
        //final iteration should grab these from the database.
        GameCharacter GFight1 = new GameCharacter
        {
            Name = "Friste",
            STR = 8,
            DEF = 20,
            VIT = 60,
            XP = 0
        };

        GameCharacter GFight2 = new GameCharacter
        {
            Name = "Lukas",
            STR = 12,
            DEF = 24,
            VIT = 55,
            XP = 0
        };

        private void BtnSetFighters_Click(object sender, EventArgs e)
        {
            SetFighters(GFight1, GFight2);
        }


        /// <summary>
        /// takes in two fighters, and determines who goes first with a coin flip.
        /// </summary>
        /// <param name="Fighter1"></param>
        /// <param name="Fighter2"></param>
        private void SetFighters(GameCharacter Fighter1, GameCharacter Fighter2)
        {


            lblFighterOne.Text = Fighter1.Name;
            txtDEF1.Text = Convert.ToString(Fighter1.DEF);
            txtVIT1.Text = Convert.ToString(Fighter1.VIT);
            txtSTR1.Text = Convert.ToString(Fighter1.STR);

            lblFighterTwo.Text = Fighter2.Name;
            txtDEF2.Text = Convert.ToString(Fighter2.DEF);
            txtVIT2.Text = Convert.ToString(Fighter2.VIT);
            txtSTR2.Text = Convert.ToString(Fighter2.STR);

            //beginning of code to determine winner. could possibly use refactoring.
            //block chance is calculated by how much defense a character has. 
            //random numbers are chosen from 1 to the number of defense,
            //this is checked against a random number made by the sum of both defense stats.
            //it's somewhat random but simple.

            lblHP1.Text = Convert.ToString(Fighter1.VIT);
            lblHP2.Text = Convert.ToString(Fighter2.VIT);

            lblHP1.Visible = true;
            lblHP2.Visible = true;

            Random Block = new Random();

            while (Fighter1.VIT > 0 && Fighter2.VIT > 0)
            {
                int F1Block = Block.Next(1, (Fighter1.DEF + 1));
                int F2Block = Block.Next(1, (Fighter2.DEF + 1));
                int BlockChance = Block.Next(1, (Fighter1.DEF + Fighter2.DEF + 1));

                if (F2Block == BlockChance)
                {
                    MessageBox.Show(Fighter1.Name + "'s damage was blocked!");
                }
                else
                {
                    Fighter2.VIT -= Fighter1.STR;
                    lblHP2.Text = Convert.ToString(Fighter2.VIT);
                    Thread.Sleep(500);
                }

                if (F1Block == BlockChance)
                {
                    MessageBox.Show(Fighter2.Name + "'s damage was Blocked!");
                }
                else
                {
                    Fighter1.VIT -= Fighter1.STR;
                    lblHP1.Text = Convert.ToString(Fighter1.VIT);
                    Thread.Sleep(500);
                }

            }

            if (Fighter1.VIT <= 0 && Fighter2.VIT > 0)
            {
                MessageBox.Show(Fighter2.Name + " Won the battle");
                
            }
            else if (Fighter2.VIT <= 0 && Fighter1.VIT > 0)
            {
                MessageBox.Show(Fighter1.Name + " Won the battle");
            } else
            {
                MessageBox.Show("The battle was a draw.");
            }


        }


    }


}


