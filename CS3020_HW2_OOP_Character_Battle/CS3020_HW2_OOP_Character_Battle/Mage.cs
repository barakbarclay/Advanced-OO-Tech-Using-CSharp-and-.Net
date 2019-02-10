using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW2_OOP_Character_Battle
{
    class Mage : Character
    {
        public Mage (int num, int position)
        {
            moveSpeed = 1;
            damagePerAttack = 20;
            health = 50;
            priority = 2;
            attackRange = 6;
            this.position = position;
            this.num = num;
        }

        public override string GetSpecialDescription()
        {
            return "2. Special (knock back the opponent 4 units, range = 3, deals 3 damage)";
        }
        public override string Special(Character target)
        {
            int specialAttackRange = 3;
            int specialDamage = 3;
            int specialKnockback = 4;
            if (target.position >= (this.position - specialAttackRange) && target.position <= this.position + specialAttackRange)
            {
                target.TakeDamage(specialDamage);
                if (target.position >= this.position)
                {
                    target.position += specialKnockback;
                }
                else
                {
                    target.position -= specialKnockback;
                }
                return "Your special has landed.";
            }
            else
            {
                return "You are out of range.";
            }
        }  
    }
}
