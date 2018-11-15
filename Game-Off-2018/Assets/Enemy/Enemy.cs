using UnityEngine;

namespace Assets.Enemy
{
    public abstract class Enemy
    {
        public Enemy(Enemy enemy)
        {
            MaxHealth = enemy.MaxHealth;
            CurrentHealth = enemy.CurrentHealth;
            MovementSpeed = enemy.MovementSpeed;
        }

        public Enemy(int maxHealth, int movementSpeed)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            MovementSpeed = movementSpeed;
        }

        private void TakeDamage(int health)
        {
            CurrentHealth -= health;
        }

        public virtual GameObject GetPrefab()
        {
            return Resources.Load<GameObject>("DefaultEnemy");
        }

        /// <summary>
        /// Max enemy health
        /// </summary>
        public int MaxHealth { get; set; }
        /// <summary>
        /// Current enemy health
        /// </summary>
        public int CurrentHealth { get; set; }
        /// <summary>
        /// The movementspeed of the object
        /// </summary>
        public float MovementSpeed { get; set; }
    }
}