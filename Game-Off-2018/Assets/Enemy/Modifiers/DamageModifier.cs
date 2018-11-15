using System.ComponentModel;

namespace Assets.Enemy.Modifiers
{
    class DamageModifier : EnemyModifier
    {
        private int _damage;

        public DamageModifier(int duration, int damage) : base(duration)
        {
            _damage = damage;
        }

        public override void Tick(Enemy enemy)
        {
            enemy.CurrentHealth -= _damage;
        }
    }
}
