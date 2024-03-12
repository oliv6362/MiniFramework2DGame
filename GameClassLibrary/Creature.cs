using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibrary
{
    public class Creature
    {
        private string Name { get; set; }
        private int HitPoint { get; set; }

        private List<AttackItem> AttackItems = new List<AttackItem>();
        private List<DefenseItem> DefenseItems = new List<DefenseItem>();

        public void hit()
        {

        }

        public void receiveHit(int hit)
        {

        }

        public void loot(WorldObject obj)
        {

        }

    }
}
