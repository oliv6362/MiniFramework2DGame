using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibrary
{
    public class Armor : WorldObject
    {
        private int ArmorID { get; set; }
        private string ArmorName { get; set; }
        private int ReduceHitPoint { get; set; }  
        
        public Armor(int armorID, string armorName, int reduceHitPoint)
        {
            ArmorID = armorID;
            ArmorName = armorName;
            ReduceHitPoint = reduceHitPoint;
        }

    }
}
