using Assets.Enemy.Modifiers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Assets.Enemy
{
    public class SpawnableEnemy : MonoBehaviour
    {
        private NavMeshPath _path;
        private NavMeshHit _agentHit;

        /// <summary>
        /// Used for debugging
        /// </summary>
        private float _elapsed = 0.0f;
        private bool _blocked = false;

        /// <summary>
        /// Position for waypoint counter
        /// </summary>
        private int position = 0;

        public Enemy Enemy { get; set; }

        private void Start()
        {
            this.Agent = this.gameObject.AddComponent<NavMeshAgent>();

            this.Agent.speed = 4;
            this.Agent.radius = 1;
            this.Agent.acceleration = 2;
            this.Agent.autoRepath = true;
            this.Agent.destination = WayPoints[position].position;


            _path = new NavMeshPath();
            _agentHit = new NavMeshHit();
        }

        private void Update()
        {
            var distance = Vector3.Distance(WayPoints[position].position, transform.position);
            Transform currentTarget = WayPoints[position];

            //Get closer, swap to new target.
            if (distance < 2)
            {
                if (position < WayPoints.Count - 1)
                {
                    position++;
                    Agent.destination = WayPoints[position].position;

                    if (Vector3.Distance(WayPoints[WayPoints.Count - 1].position, transform.position) < 2)
                        Destroy(this.gameObject);
                }
            }

            _blocked = NavMesh.Raycast(transform.position, WayPoints[position].transform.position, out _agentHit, NavMesh.AllAreas);
            Debug.DrawLine(transform.position, WayPoints[position].transform.position, _blocked ? Color.red : Color.green);
            if (_blocked)
                Debug.DrawRay(_agentHit.position, Vector3.up, Color.red);
        }

     
        /// <summary>
        /// WayPoints to move to in lifetime of Movement
        /// </summary>
        public List<Transform> WayPoints { get; set; }
        /// <summary>
        /// EndPoint where the object ends if it's livetime makes it.
        /// </summary>
        public Transform EndPoint { get; set; }
        /// <summary>
        /// A.I Agent used for PathFinding
        /// </summary>
        public NavMeshAgent Agent { get; set; }
        /// <summary>
        /// Current enemy modifiers
        /// </summary>
        public List<EnemyModifier> EnemyModifiers { get; set; }
    }
}
