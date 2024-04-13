using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.TemplateDesignPattern
{
    public class Goblin : AbstractCreature
    {
        public Goblin(int creatureID, string creatureName, Vector2 position)
            : base(creatureID, creatureName, position)
        {
        }

        protected override void InitializeCreature()
        {
            MaxHitPoint = 50; 
            CurrentHitPoint = MaxHitPoint;
        }
    }
}
