﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Assets.Enemy.Modifiers
{ 
    class AttackSpeedModifier : EnemyModifier
    {
        private int _attackSpeedModifier;

        public AttackSpeedModifier(int duration, int modifier) : base(duration, modifier)
        {
            duration = 60;
            _attackSpeedModifier = modifier;
        }

        protected override void worker_Tick(object sender, DoWorkEventArgs e)
        {
            this.Enemy.MovementSpeed += _attackSpeedModifier;
        }
    }
}