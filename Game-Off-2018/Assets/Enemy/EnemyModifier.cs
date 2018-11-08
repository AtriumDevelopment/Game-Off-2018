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
        private BackgroundWorker _backGroundWorker;

        private Enemy enemy;

        public EnemyModifier(int duration, int _tickrate) {
            this._duration = duration;
            this._tickRate = _tickRate;

            _backGroundWorker = new BackgroundWorker();
            _backGroundWorker.DoWork += worker_Tick;
            System.Timers.Timer timer = new System.Timers.Timer(1000);
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

        //public void Tick(Enemy enemy)
        //{
        
            

        //}
    }
}
