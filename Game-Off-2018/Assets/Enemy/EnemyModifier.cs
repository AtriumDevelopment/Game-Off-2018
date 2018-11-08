using System;
using System.ComponentModel;
using System.Threading;
using System.Timers;

namespace Assets.Enemy
{
    public abstract class EnemyModifier 
    {
        private int _duration;
        private int _tickRate;
        private Enemy enemy;

        private BackgroundWorker _backGroundWorker;

        public EnemyModifier(int duration, int tickRate) {
            this._duration = duration;
            this._tickRate = tickRate;

            SetWorker();
        }

        public void SetWorker() {
            _backGroundWorker = new BackgroundWorker();
            _backGroundWorker.DoWork += worker_Tick;

            System.Timers.Timer timer = new System.Timers.Timer(_tickRate);
            timer.Elapsed += timer_Elapsed;

            timer.Start();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //Run worker
            if (!_backGroundWorker.IsBusy)
                _backGroundWorker.RunWorkerAsync();
        }

        private void worker_Tick(object sender, DoWorkEventArgs e)
        {
            //enemy.   
        }
    }
}
