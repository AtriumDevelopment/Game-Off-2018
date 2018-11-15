﻿using UnityEngine;

namespace Assets.Enemy
{
    public abstract class Enemy : ScriptableObject
    {
        public virtual void Initialize(int maxHealth, int movementSpeed)
        {
            this.MaxHealth = maxHealth;
            this.CurrentHealth = maxHealth;
            this.MovementSpeed = 100;
        }

        private void TakeDamage(int health)
        {
            this.CurrentHealth -= health;
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