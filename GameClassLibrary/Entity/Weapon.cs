using GameClassLibraryFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Entity
{
    public class Weapon : WorldObject, IWeapon
    {
        public int WeaponID { get; private set; }
        public string WeaponName { get; private set; }
        public int WeaponDamage { get; private set; }
        public int WeaponRange { get; private set; }

        public Weapon(int weaponID, string weaponName, int weaponDamage, int weaponRange)
        {
            WeaponID = weaponID;
            WeaponName = weaponName;
            WeaponDamage = weaponDamage;
            WeaponRange = weaponRange;

        }

        public void CalculateDamage()
        {
            // Implementation of damage calculation
        }
    }
}

