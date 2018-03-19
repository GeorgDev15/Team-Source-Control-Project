using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCharacterCreator
{
    class Damage
    {
        public int Attacker1()
        {
            GameCharacter character = new GameCharacter();
            Random rand = new Random();

            int atk = character.STR;
            int atkAfterRand = rand.Next(0, 6);

            atk += atkAfterRand;
            return atk;
        }

        public int Defender1()
        {
            GameCharacter character = new GameCharacter();
            Random rand = new Random();

            int def = character.DEF;
            int defAfterRand = rand.Next(0, 4);

            def += defAfterRand;
            return def;
        }

        public int Attacker2()
        {
            GameCharacter character = new GameCharacter();
            Random rand = new Random();

            int atk = character.STR;
            int atkAfterRand = rand.Next(0, 6);

            atk += atkAfterRand;
            return atk;
        }

        public int Defender2()
        {
            GameCharacter character = new GameCharacter();
            Random rand = new Random();

            int def = character.DEF;
            int defAfterRand = rand.Next(0, 4);

            def += defAfterRand;
            return def;
        }

        public int HP()
        {
            GameCharacter character = new GameCharacter();

            int hp = character.VIT;

            return hp;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
