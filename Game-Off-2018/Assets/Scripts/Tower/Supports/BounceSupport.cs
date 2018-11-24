using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Scripts.Tower.Attacks;
using Assets.Scripts.Tower.Targeting;

namespace Assets.Scripts.Tower.Supports
{
    class BounceSupport : ISupport
    {
        public void Apply(Attack attack)
        {
            attack.gameObject.AddComponent<BounceTargeting>();
        }
    }
}
