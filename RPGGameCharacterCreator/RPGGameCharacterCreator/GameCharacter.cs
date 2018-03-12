using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameCharacterCreator
{
    class GameCharacter
    {
        /// <summary>
        /// Properties of the GameCharacter object
        /// Legend:
        /// - XP = Experience points
        /// - VIT = Vitality
        /// - STR = Strength
        /// - DEF = Defense
        /// </summary>
        public string Name { get; set; }
        public int XP { get; set; }
        public int VIT { get; set; }
        public int STR { get; set; }
        public int DEF { get; set; }
    }
}
