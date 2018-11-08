using System.ComponentModel;
using System.Timers;

namespace Assets.Enemy.Modifiers
{
    public abstract class EnemyModifier 
    {
        private int _duration;
        private readonly int _tickRate = 1000;
        private Enemy _enemy;
        private Timer _timer;
        private int totalTimeRunning;

        private BackgroundWorker _backGroundWorker;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="duration">In seconds</param>
        /// <param name="modifier">Modifier amount</param>
        public EnemyModifier(int duration, int modifier) {
            this._duration = duration;

            SetWorker();
        }

        public void SetWorker() {
            _backGroundWorker = new BackgroundWorker();
            _backGroundWorker.DoWork += worker_Tick;

            _timer = new System.Timers.Timer(_tickRate);
            _timer.Elapsed += timer_Elapsed;
            
            _timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            totalTimeRunning++;

            //Run worker
            if (!_backGroundWorker.IsBusy)
                _backGroundWorker.RunWorkerAsync();

            if (_duration * 60 == totalTimeRunning)
                this._backGroundWorker.CancelAsync();
        }

        protected virtual void worker_Tick(object sender, DoWorkEventArgs e)
        {


        }

        public Enemy Enemy { get { return _enemy; } }
    }
}
