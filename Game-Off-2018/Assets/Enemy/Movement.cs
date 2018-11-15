//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class Movement : MonoBehaviour {

//    private NavMeshPath _path;
//    private NavMeshHit _agentHit;

//    /// <summary>
//    /// Used for debugging
//    /// </summary>
//    private float _elapsed = 0.0f;
//    private bool _blocked = false;
    
//    /// <summary>
//    /// Position for waypoint counter
//    /// </summary>
//    private int position = 0;


//    /// <summary>
//    /// 
//    /// </summary>
//    void Start ()
//    {
//        this.Agent = this.gameObject.AddComponent<NavMeshAgent>();
//        this.Agent.radius = 1;

//        this.Agent.autoRepath = true;
//        this.Agent.acceleration = MovementSpeed;

//        this.Agent.destination = WayPoints[position].position;

//        GameObject endLocation = GameObject.Find("EndPoint");


//        _path = new NavMeshPath();
//        _agentHit = new NavMeshHit();
//    }

//    // Update is called once per frame
//    void Update () {
//        //Agent.destination = EndPoint.transform.position;

//        var distance = Vector3.Distance(WayPoints[position].position, transform.position);
//        Transform currentTarget = WayPoints[position];

//        //Get closer, swap to new target.
//        if (distance < 2)
//        {
//            if (position < WayPoints.Count - 1)
//            {
//                position++;
//                Agent.destination = WayPoints[position].position;
//            }
//        }

//        _blocked = NavMesh.Raycast(transform.position, WayPoints[position].transform.position, out _agentHit, NavMesh.AllAreas);
//        Debug.DrawLine(transform.position, WayPoints[position].transform.position, _blocked ? Color.red : Color.green);
//        if (_blocked)
//            Debug.DrawRay(_agentHit.position, Vector3.up, Color.red);
//    }

   

//}
