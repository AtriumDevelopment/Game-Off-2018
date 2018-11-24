using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Tower.Targeting
{
    public abstract class Targeting : MonoBehaviour
    {
        protected GameManager GameManager;

        private void Start()
        {
            GameManager = GameObject.Find("World").GetComponent<GameManager>();
        }

        public abstract List<Transform> GetTargets();

        public Transform GetFirstTarget()
        {
            return GetTargets() == null || GetTargets().Count == 0 ? null : GetTargets()[0];
        }

    }
}
