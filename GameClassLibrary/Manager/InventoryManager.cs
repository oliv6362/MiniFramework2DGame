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
        public List<IWeapon> WeaponItems = new List<IWeapon>();
        public List<IArmor> ArmorItems = new List<IArmor>();

        public void AddWeapon(IWeapon weapon)
        {
            GameLogger.Instance.LogInformation("Weapon added: " + weapon.WeaponName);
            WeaponItems.Add(weapon);

        }

        public void RemoveWeapon(IWeapon weapon)
        {
            if (WeaponItems.Remove(weapon))
            {
                GameLogger.Instance.LogInformation("Weapon removed: " + weapon.WeaponName);
            }
            else
            {
                GameLogger.Instance.LogWarning("Attempt to remove weapon failed: " + weapon.WeaponName);
            }
        }

        public void AddArmor(IArmor armor)
        {
            GameLogger.Instance.LogInformation("Armor added: " + armor.ArmorName);
            ArmorItems.Add(armor);
        }

        public void RemoveArmor(IArmor armor)
        {
            if (ArmorItems.Remove(armor))
            {
                GameLogger.Instance.LogInformation("Armor removed: " + armor.ArmorName);
            }
            else
            {
                GameLogger.Instance.LogWarning("Attempt to remove armor failed: " + armor.ArmorName);
            }
        }
    }
}
