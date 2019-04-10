using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class BasicEnemy
    {
        private int maxHealth;
        private int currentHealth;
        private int attackDamage;
        private int playerDamage;

        public BasicEnemy(int health, int damage)
        {
            this.maxHealth = health;
            this.attackDamage = damage;
        }

        private void TakeDamage()
        {

        }
        private void AttackPlayer()
        {

        }
    }
    
}
