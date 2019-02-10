using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW2_OOP_Character_Battle
{
    class Archer : Character
    {
        public Archer(int num, int position)
        {
            moveSpeed = 3;
            damagePerAttack = 15;
            health = 65;
            priority = 1;
            attackRange = 3;
            this.position = position;
            this.num = num;
        }

        public override string GetSpecialDescription()
        {
            return "2. Special (12 range attack, deals 10 damage)";
        }
        public override string Special(Character target)
        {
            int specialAttackRange = 12;
            int specialDamage = 10;
            if (target.position >= (this.position - specialAttackRange) && target.position <= this.position + specialAttackRange)
            {
                target.TakeDamage(specialDamage);
                return "Your special has landed.";
            }
            else
            {
                return "You are out of range.";
            }
        }
    }
}
