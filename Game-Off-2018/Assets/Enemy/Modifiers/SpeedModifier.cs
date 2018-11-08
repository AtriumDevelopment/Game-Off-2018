using System.ComponentModel;

namespace Assets.Enemy.Modifiers
{
    class SpeedModifier : EnemyModifier
    {
        private int _speedModifier;

        public SpeedModifier(int duration, int modifier) : base(duration, modifier)
        {
            duration = 60;
            _speedModifier = modifier;
        }

        protected override void worker_Tick(object sender, DoWorkEventArgs e)
        {
            this.Enemy.MovementSpeed += _speedModifier;   
        }
    }
}
