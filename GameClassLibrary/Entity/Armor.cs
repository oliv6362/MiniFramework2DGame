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
        public int ReduceHitPoint { get; private set; }



        public Armor(int armorID, string armorName, int reduceHitPoint)
        {
            ArmorID = armorID;
            ArmorName = armorName;
            ReduceHitPoint = reduceHitPoint;
        }

    }
}
