using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Manager
{
    public class InventoryManager
    {
        private List<IWeapon> WeaponItems = new List<IWeapon>();
        private List<Armor> ArmorItems = new List<Armor>();

        public void AddWeapon(IWeapon weapon)
        {
            WeaponItems.Add(weapon);
        }

        public void RemoveWeapon(IWeapon weapon)
        {
            WeaponItems.Remove(weapon);
        }

        public void AddArmor(Armor armor)
        {
            ArmorItems.Add(armor);
        }

        public void RemoveArmor(Armor armor)
        {
            ArmorItems.Remove(armor);
        }
    }
}
