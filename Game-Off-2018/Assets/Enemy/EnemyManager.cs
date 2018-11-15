using UnityEngine;
using Assets.Enemy;
using System.Collections.Generic;

public class EnemyManager : ScriptableObject
{
    // Use this for initialization
    public float spawnTime;
    public float spawnAmount;

    public GameObject enemyPrefab;

    public Transform SpawnPoint;
    public Transform EndPoint;
    public List<Transform> Waypoints;

    public List<Enemy> currentEnemies;

  
    public void SpawnEnemies(List<Dictionary<Enemy, int>> enemies)
    {
        for (int i = 0; i < enemies.Count; i++) {
            Dictionary<Enemy, int> dictionary = enemies[i];

            foreach (var item in dictionary)
            {
                for (int j = 0; j < item.Value; j++) {
                    Enemy c = item.Key;
                    c.Initialize(10, 10);
                    SpawnEnemy(c);
                }
            }
        }
    }


    public void SpawnEnemy(Enemy enemy)
    {
        var instantiatedEnemy = Instantiate(enemyPrefab, SpawnPoint, SpawnPoint);

        SpawnableEnemy EnemyInstnace = instantiatedEnemy.AddComponent<SpawnableEnemy>();
        EnemyInstnace.Enemy = enemy;


        EnemyInstnace.WayPoints = this.Waypoints;
        EnemyInstnace.EndPoint = this.EndPoint;
        EnemyInstnace.transform.position = SpawnPoint.position;

        currentEnemies.Add(enemy);
    }


    public List<Enemy> AllEnemies { get { return currentEnemies; } }
}
