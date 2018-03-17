using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGGameCharacterCreator
{
    class CharacterDB
    {
        public static void AddCharacter(GameCharacter character)
        {
            CharacterCreatorDB db = new CharacterCreatorDB();
            db.GameCharacters.Add(character);
            MessageBox.Show("Character Added");

            db.SaveChanges();
        }
    }
}
