using GameClassLibraryFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Entity
{
    public class Armor : WorldObject, IArmor
    {
        public int ArmorID { get; private set; }
        public string ArmorName { get; private set; }
        public int DefenseRating { get; private set; }

        public Armor(int armorID, string armorName, int defenseRating)
        {
            ArmorID = armorID;
            ArmorName = armorName;
            DefenseRating = defenseRating;
        }

        public int ReduceDamage(int incomingDamage)
        {
            return Math.Max(incomingDamage - DefenseRating, 0); 
        }
    }
}
