namespace Assets.Enemy
{
    public class Goblin : Enemy
    { 
        public Goblin(int maxHealth) : base(maxHealth)
        {
            maxHealth = 200;
            MovementSpeed = 10;
        }
    }
}
