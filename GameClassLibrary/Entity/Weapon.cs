using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Entity
{
    public class Weapon : WorldObject
    {
        private int WeaponID { get; set; }
        private string WeaponName { get; set; }
        private string DamageAmount { get; set; }
        private int WeaponHit { get; set; }
        private int WeaponRange { get; set; }

        public Weapon(int weaponID, string weaponName, string damageAmount, int weaponHit, int weaponRange)
        {
            WeaponID = weaponID;
            WeaponName = weaponName;
            DamageAmount = damageAmount;
            WeaponHit = weaponHit;
            WeaponRange = weaponRange;
        }


    }
}
