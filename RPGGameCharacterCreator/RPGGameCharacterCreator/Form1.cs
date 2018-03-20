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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CreateCharacter().ShowDialog(); 
        }

        private void BtnCharacterSelect1_Click(object sender, EventArgs e)
        {
            CharacterPicker characterPicker = new CharacterPicker();
            characterPicker.ShowDialog();
        }

        private void PopulateCharacterComboBox()
        {
            cboCharacterSelect1.Items.Clear();
            cboCharacterSelect2.Items.Clear();

            try
            {
                List<GameCharacter> characters = CharacterDB.getAllCharacters();

                foreach (GameCharacter character in characters)
                {
                    cboCharacterSelect1.Items.Add(character);
                    cboCharacterSelect2.Items.Add(character);
                }
            }
            catch
            {
                MessageBox.Show("Error, please try again later");
                Application.Exit();
            }
        }

        private void cboCharacterSelect1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameCharacter character = (GameCharacter)cboCharacterSelect1.SelectedItem;
            lblName1.Text = character.Name.ToString();
            lblName1.Font = new Font("Arial", 12, FontStyle.Bold);
            txtDef1.Text = character.DEF.ToString();
            txtHp1.Text = character.VIT.ToString();
            txtStr1.Text = character.STR.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCharacterComboBox();
        }

        private void cboCharacterSelect2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameCharacter character2 = (GameCharacter)cboCharacterSelect2.SelectedItem;
            lblName2.Text = character2.Name.ToString();
            lblName2.Font = new Font("Arial", 12, FontStyle.Bold);
            txtDef2.Text = character2.DEF.ToString();
            txtHp2.Text = character2.VIT.ToString();
            txtStr2.Text = character2.STR.ToString();
        }

        private void BtnFight_Click(object sender, EventArgs e)
        {
            try
            {
                Damage dmg = new Damage();

                GameCharacter character = new GameCharacter();

                // players do "damage" to eachother
                int damage = Convert.ToInt32(dmg.Attacker1());
                int defense = Convert.ToInt32(dmg.Defender1());

                int attack = Convert.ToInt32(dmg.Attacker2());
                int block = Convert.ToInt32(dmg.Defender2());

                int start1 = Convert.ToInt32(txtHp1.Text);
                int start2 = Convert.ToInt32(txtHp2.Text);

                int currHP = start1 - damage + defense;
                int currentHP = start2 - attack + block;

                txtHp1.Text = Convert.ToString(currHP);
                txtHp2.Text = Convert.ToString(currentHP);

                if (Convert.ToInt32(currentHP) < 1)
                {
                    MessageBox.Show("Figher 1 wins! Gained 100XP");
                    int xpEarned = 100;
                    character.XP = xpEarned;
                    ClearField();
                }
                if (Convert.ToInt32(currHP) < 1)
                {
                    MessageBox.Show("Fighter 2 wins! Gained 100XP");
                    int xpEarned = 100;
                    character.XP = xpEarned;
                    ClearField();
                }
            }
            catch
            {
                MessageBox.Show("Please select the characters that will fight eachother.");
            }
            // this is just a test, it works as it should but it needs to clear the board after someone loses
        }

        public void ClearField()
        {
            txtDef1.Text = "";
            txtDef2.Text = "";
            txtHp1.Text = "";
            txtHp2.Text = "";
            txtStr1.Text = "";
            txtStr2.Text = "";
            cboCharacterSelect1.Text = "Select A Character";
            cboCharacterSelect2.Text = "Select A Character";
            lblName1.Text = "";
            lblName2.Text = "";
        }
    }
}
