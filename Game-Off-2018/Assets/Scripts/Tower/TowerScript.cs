using System.Collections.Generic;
using Assets.Scripts.Tower.Attacks;
using Assets.Scripts.Tower.Supports;
using UnityEngine;

namespace Assets.Scripts.Tower
{
    public class TowerScript : MonoBehaviour
    {
        public List<ISupport> Supports { get; set; }

        // Use this for initialization
        private void Start()
        {
            Supports = new List<ISupport>();
            Supports.Add(new BounceSupport());
            gameObject.AddComponent<DefaultAttack>();

            var test = gameObject.GetComponents<Attack>();

            foreach (var attack in test)
            {
                foreach (var support in Supports)
                {
                    support.Apply(attack);
                }
            }
        }
    }
}