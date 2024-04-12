using GameClassLibraryFramework.Entity;
using GameClassLibraryFramework.TracingAndLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClassLibraryFramework.Manager
{
    public class CombatManager
    {
        /// <summary>
        /// Initiates combat between two creatures. Continues until one creature is defeated.
        /// </summary>
        public void Engage(Creature attacker, Creature defender)
        {
            GameLogger.Instance.LogInformation($"Combat started between {attacker.CreatureName} and {defender.CreatureName}.");

            while (attacker.CurrentHitPoint > 0 && defender.CurrentHitPoint > 0)
            {
                PerformAttack(attacker, defender);
                if (defender.CurrentHitPoint > 0)
                {
                    PerformAttack(defender, attacker);
                }
            }

            Creature winner = attacker.CurrentHitPoint > 0 ? attacker : defender;
            Creature loser = attacker.CurrentHitPoint <= 0 ? attacker : defender;

            GameLogger.Instance.LogInformation($"Combat ended. {winner.CreatureName} defeated {loser.CreatureName} and wins!.");
        }

        /// <summary>
        /// Performs an attack and handles damage calculation and application.
        /// </summary>
        private void PerformAttack(Creature attacker, Creature defender)
        {
            if (attacker.Inventory.WeaponItems.Any())
            {
                int totalDamage = attacker.Inventory.WeaponItems.Sum(weapon => weapon.CalculateDamage());
                int damageTaken = ApplyDamage(defender, totalDamage);
                GameLogger.Instance.LogInformation($"{attacker.CreatureName} attacked {defender.CreatureName} for {totalDamage} damage. {defender.CreatureName} now has {defender.CurrentHitPoint} HP after taking {damageTaken} damage.");
            }
            else
            {
                GameLogger.Instance.LogInformation($"{attacker.CreatureName} tried to attack but has no weapons.");
            }
        }

        /// <summary>
        /// Applies damage to the creature, considering armor defense.
        /// </summary>
        private int ApplyDamage(Creature creature, int damage)
        {
            int reducedDamage = damage;
            if (creature.Inventory.ArmorItems.Any())
            {
                reducedDamage = creature.Inventory.ArmorItems.Aggregate(damage, (current, armor) => armor.ReduceDamage(current));
            }
            creature.CurrentHitPoint = Math.Max(creature.CurrentHitPoint - reducedDamage, 0);
            return reducedDamage;
        }
    }
}







