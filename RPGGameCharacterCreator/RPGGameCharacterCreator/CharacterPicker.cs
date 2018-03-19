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
    public partial class CharacterPicker : Form
    {
        public CharacterPicker()
        {
            InitializeComponent();
        }

        private void CharacterPicker_Load(object sender, EventArgs e)
        {
            PopulateCharacterList();
        }

        private void PopulateCharacterList()
        {
            lstCharacters.Items.Clear();

            try
            {
                List<GameCharacter> characters = CharacterDB.getAllCharacters();

                foreach (GameCharacter character in characters)
                {
                    lstCharacters.Items.Add(character);
                }
            }
            catch
            {
                MessageBox.Show("Error, please try again later");
                Application.Exit();
            }
        }
    }
}
