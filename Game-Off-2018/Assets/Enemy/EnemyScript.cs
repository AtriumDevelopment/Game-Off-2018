using System.Collections.Generic;
using Assets.Enemy.Modifiers;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Enemy
{
    public class EnemyScript : MonoBehaviour
    {
        public delegate void OnDeath(GameObject gameObject);

        private NavMeshHit _agentHit;
        private bool _blocked;

        /// <summary>
        ///     Used for debugging
        /// </summary>
        private float _elapsed = 0.0f;

        private NavMeshPath _path;
        public OnDeath OnDeathDelegate;

        /// <summary>
        ///     Position for waypoint counter
        /// </summary>
        private int position;

        public Enemy Enemy { get; set; }


        /// <summary>
        ///     WayPoints to move to in lifetime of Movement
        /// </summary>
        public List<Vector3> WayPoints { get; set; }

        /// <summary>
        ///     A.I Agent used for PathFinding
        /// </summary>
        public NavMeshAgent Agent { get; set; }

        /// <summary>
        ///     Current enemy modifiers
        /// </summary>
        public List<EnemyModifier> EnemyModifiers { get; set; }

        private void Start()
        {
            EnemyModifiers = new List<EnemyModifier>();
            Agent = gameObject.AddComponent<NavMeshAgent>();
            Agent.speed = 4;
            Agent.radius = 1;
            Agent.acceleration = 2;
            Agent.autoRepath = true;
            Agent.destination = WayPoints[position];


            _path = new NavMeshPath();
            _agentHit = new NavMeshHit();
        }

        private void Update()
        {
            var distance = Vector3.Distance(WayPoints[position], transform.position);

            //Get closer, swap to new target.
            if (distance < 2)
            {
                if (position < WayPoints.Count - 1)
                {
                    position++;
                    Agent.destination = WayPoints[position];
                }

                if (position == WayPoints.Count - 1)
                    OnDeathDelegate(gameObject);
            }

            _blocked = NavMesh.Raycast(transform.position, WayPoints[position], out _agentHit, NavMesh.AllAreas);
            Debug.DrawLine(transform.position, WayPoints[position], _blocked ? Color.red : Color.green);
            if (_blocked)
                Debug.DrawRay(_agentHit.position, Vector3.up, Color.red);

            foreach (var enemyModifier in EnemyModifiers)
            {
                enemyModifier.Tick(Enemy);
            }

            if (Enemy.CurrentHealth <= 0)
            {
                OnDeathDelegate(gameObject);
            }
        }
    }
}