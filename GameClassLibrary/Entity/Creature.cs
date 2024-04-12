﻿using GameClassLibraryFramework.Interfaces;
using GameClassLibraryFramework.Manager;
using GameClassLibraryFramework.TracingAndLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Entity
{
    public class Creature : IMovable
    {
        public int CreatureID { get; private set; }
        public string CreatureName { get; private set; }
        public int MaxHitPoint { get; private set; }
        public int CurrentHitPoint { get; private set; }
        public Vector2 Position { get; set; }
        public InventoryManager Inventory { get; private set; }

        public Creature(int creatureID, string creatureName, int maxHitPoint, int currentHitPoint, Vector2 position)
        {
            CreatureID = creatureID;
            CreatureName = creatureName;
            MaxHitPoint = maxHitPoint;
            CurrentHitPoint = currentHitPoint;
            Position = position;
            Inventory = new InventoryManager();
        }

        public void Move(Vector2 newPosition)
        {
            Position = newPosition;
        }

        public void AddWeapon(IWeapon weapon)
        {
            Inventory.AddWeapon(weapon);
        }
        
        public void RemoveWeapon(IWeapon weapon)
        {
            Inventory.RemoveWeapon(weapon);
        }

        public void AddArmor(Armor armor)
        {
            Inventory.AddArmor(armor);
        }

        public void RemoveArmor(Armor armor)
        {
            Inventory.RemoveArmor(armor);
        }
    }
}