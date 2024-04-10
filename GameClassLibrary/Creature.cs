using GameClassLibraryFramework.TracingAndLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibrary
{
    public class Creature
    {
        private string CreatureID { get; set; }
        private string CreatureName { get; set; }
        private int MaxHitPoint { get; set; }
        private int CurrentHitPoint { get; set; }
        private Vector2 Position { get; set; }

        private List<Weapon> AttackItems = new List<Weapon>();
        private List<Armor> DefenseItems = new List<Armor>();

        public Creature(string creatureID, string creatureName, int maxHitPoint, int currentHitPoint, Vector2 position)
        {
            CreatureID = creatureID;
            CreatureName = creatureName;
            MaxHitPoint = maxHitPoint;
            CurrentHitPoint = currentHitPoint;
            Position = position;
        }

        public void hit()
        {


        }

        public void receiveHit(int hit)
        {

        }

        public void loot(WorldObject obj)
        {

        }

        public void AddCreature(Creature creature)
        {
            //Creatures.Add(creature);
            GameLogger.Instance.LogInformation("Creature is being added...");
            
        }

        public void RemoveCreature(Creature creature)
        {
            //Creatures.Remove(this);
            GameLogger.Instance.LogInformation("Creature is being removed...");
        }

    }
}
