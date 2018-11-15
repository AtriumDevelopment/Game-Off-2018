namespace Assets.Enemy
{
    public class Goblin : Enemy
    {
        public Goblin(Enemy enemy) : base(enemy)
        {
        }

        public Goblin(int maxHealth, int movementSpeed) : base(maxHealth, movementSpeed)
        {
        }
    }
}
