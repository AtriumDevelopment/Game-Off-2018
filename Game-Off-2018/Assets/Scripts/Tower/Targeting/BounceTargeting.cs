using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal.Profiling;
using UnityEngine;

namespace Assets.Scripts.Tower.Targeting
{
    public class BounceTargeting : Targeting
    {
        public override List<Transform> GetTargets()
        {
            var targets = new List<Transform>();
            for (int i = 0; i < (GameManager.EnemyManager.CurrentEnemies.Count > 5 ? 5 : GameManager.EnemyManager.CurrentEnemies.Count); i++)
            {
                targets.Add(GameManager.EnemyManager.CurrentEnemies.OrderBy(e => Vector3.Distance(e.transform.position, transform.position)).ToList()[i].transform);
            }

            return targets;
        }
    }
}
