using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_HW2_OOP_Character_Battle
{
    abstract class Character
    {
        public int num { get; set; }
        public int moveSpeed { get; set; }
        public int damagePerAttack { get; set; }
        public int health { get; set; }
        public int position { get; set; }
        public int priority { get; set; }
        public int attackRange { get; set; }

        public void TakeDamage(int amount)
        {
            health -= amount;
        }
        public string GetMovementAttackDescription()
        {
            return "1. Move and attack (Max movement = " + moveSpeed + ". Attack Range = " + attackRange + ". Damage = " + damagePerAttack + ")";
        }
        public abstract string GetSpecialDescription();
        public string Move(int amount)
        {
            if ((this.position + amount) <= 50 && (this.position + amount) >= 0 && 
                amount >= -(this.moveSpeed) && amount <= this.moveSpeed)
            {
                this.position += amount;
                return "You moved.";
            }
            else
            {
                return "You cannot move there.";
            }
        }
        public string Attack(Character target)
        {
            if (target.position >= (this.position - this.attackRange) && target.position <= this.position + this.attackRange)
            {
                target.TakeDamage(this.damagePerAttack);
                return "Your hit has landed.";
            }
            else
            {
                return "You are out of range.";
            }
        }
        public abstract string Special(Character target);
    }
}
