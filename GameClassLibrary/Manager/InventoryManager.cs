using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.Interfaces;
using GameClassLibraryFramework.TracingAndLogger;
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
        private List<IArmor> ArmorItems = new List<IArmor>();

        public void AddWeapon(IWeapon weapon)
        {
            GameLogger.Instance.LogInformation("Weapon added: " + weapon.WeaponName);
            WeaponItems.Add(weapon);

        }

        public void RemoveWeapon(IWeapon weapon)
        {
            GameLogger.Instance.LogInformation("Weapon removed: " + weapon.WeaponName);
            WeaponItems.Remove(weapon);
        }

        public void AddArmor(IArmor armor)
        {
            GameLogger.Instance.LogInformation("Armor added: " + armor.ArmorName);
            ArmorItems.Add(armor);
        }

        public void RemoveArmor(IArmor armor)
        {
            GameLogger.Instance.LogInformation("Armor removed: " + armor.ArmorName);
            ArmorItems.Remove(armor);
        }
    }
}
