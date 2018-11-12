using Assets.Enemy.Modifiers;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Enemy
{
    public abstract class Enemy : MonoBehaviour
    {
        public Enemy(int maxHealth)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
            this.MovementSpeed = 100;
        }

        private void TakeDamage(int health)
        {
            this.CurrentHealth -= health;
        }

        public List<EnemyModifier> EnemyModifiers { get; set;}
        public int MovementSpeed { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
    }
}