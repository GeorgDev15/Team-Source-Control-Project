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
            //CharacterPicker characterPicker = new CharacterPicker();
            //characterPicker.ShowDialog();
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
        }

        private void cboCharacterSelect1_Click(object sender, EventArgs e)
        {
            PopulateCharacterComboBox();
        }

        private void cboCharacterSelect2_Click(object sender, EventArgs e)
        {
            PopulateCharacterComboBox();
        }
    }
}
