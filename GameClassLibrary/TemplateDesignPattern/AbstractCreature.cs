using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.Interfaces;
using GameClassLibraryFramework.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.TemplateDesignPattern
{
    public abstract class AbstractCreature : IMovable
    {
        public int CreatureID { get; private set; }
        public string CreatureName { get; private set; }
        public int MaxHitPoint { get; protected set; }
        public int CurrentHitPoint { get; set; }
        public Vector2 Position { get; set; }
        public InventoryManager Inventory { get; private set; }

        protected AbstractCreature(int creatureID, string creatureName, Vector2 position)
        {
            CreatureID = creatureID;
            CreatureName = creatureName;
            Position = position;
            Inventory = new InventoryManager();
            InitializeCreature();
        }

        protected abstract void InitializeCreature();

        public void Move(Vector2 newPosition)
        {
            Position = newPosition;
        }

        public void TakeDamage(int damage)
        {
            int reducedDamage = damage;
            if (Inventory.ArmorItems.Any())
            {
                reducedDamage = Inventory.ArmorItems.Aggregate(damage, (current, armor) => armor.ReduceDamage(current));
            }
            CurrentHitPoint = Math.Max(CurrentHitPoint - reducedDamage, 0);
        }

        public void AddWeapon(IWeapon weapon)
        {
            Inventory.AddWeapon(weapon);
        }

        public void RemoveWeapon(IWeapon weapon)
        {
            Inventory.RemoveWeapon(weapon);
        }

        public void AddArmor(IArmor armor)
        {
            Inventory.AddArmor(armor);
        }

        public void RemoveArmor(Armor armor)
        {
            Inventory.RemoveArmor(armor);
        }
    }
}
