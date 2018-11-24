using System.Collections.Generic;
using System.Linq;
using UnityEditorInternal.Profiling;
using UnityEngine;

namespace Assets.Scripts.Tower.Targeting
{
    public class DefaultTargeting : Targeting
    {
        public override List<Transform> GetTargets()
        {
            return GameManager.EnemyManager.CurrentEnemies.Count <= 0 ? null : new List<Transform> {GameManager.EnemyManager.CurrentEnemies.OrderBy(e => Vector3.Distance(e.transform.position, transform.position)).ToList()[0].transform};
        }
    }
}
