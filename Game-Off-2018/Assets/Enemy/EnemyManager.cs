﻿using Assets.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    // Use this for initialization

    public float spawnTime;
    public float spawnAmount;

    public GameObject enemyPrefab;

    public Transform SpawnPoint;
    public Transform EndPoint;
    public List<Transform> Waypoints;


    void Start()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
        }
    }

    void SpawnEnemy() {
        var enemyObject = Instantiate(enemyPrefab, SpawnPoint, SpawnPoint);

        //Type unkown get from gamemanager.
       Goblin instanceOf = enemyObject.AddComponent<Goblin>();

        //enemy.MovementSpeed;

        enemyObject.transform.position = SpawnPoint.position;

        Movement movement = enemyObject.AddComponent<Movement>();
        movement.MovementSpeed = 10;
        movement.WayPoints = this.Waypoints;
        movement.EndPoint = this.EndPoint;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
