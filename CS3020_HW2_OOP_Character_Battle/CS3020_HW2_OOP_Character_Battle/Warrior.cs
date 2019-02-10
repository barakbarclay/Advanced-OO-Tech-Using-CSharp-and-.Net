using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW2_OOP_Character_Battle
{
    class Warrior : Character
    {
        public Warrior(int num, int position)
        {
            moveSpeed = 2;
            damagePerAttack = 20;
            health = 75;
            priority = 3;
            attackRange = 1;
            this.position = position;
            this.num = num;
        }

        public override string GetSpecialDescription()
        {
            return "2. Special (leap up to 8 units to oppenent's spot if possible, if opponent is greater than 5 units away deal 30 damage)";
        }
        public override string Special(Character target)
        {
            int specialMaxLeap = 8;
            int specialDamage = 30;
            int specialAttackRange = 5;
            if (target.position >= (this.position - specialMaxLeap) && target.position <= this.position + specialMaxLeap)
            {
                if (target.position < (this.position - specialAttackRange) || target.position > this.position + specialAttackRange)
                {
                    target.TakeDamage(specialDamage);
                    this.position = target.position + 1;
                    return "Your special was used and damage was dealt.";
                }
                else
                {
                    this.position = target.position + 1;
                    return "Your special was used, but damage was not dealt.";
                }
            }
            else if (target.position > this.position)
            {
                this.position += 8;
                return "Your special was used, but damage was not dealt.";
            }
            else
            {
                this.position -= 8;
                return "Your special was used, but damage was not dealt.";
            }
        }
    }
}
