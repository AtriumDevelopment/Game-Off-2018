using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Enemy
{
    public class EnemyManager : MonoBehaviour
    {
        // Use this for initialization
        public Vector3 SpawnPoint;
        public List<Vector3> WayPoints;

        public readonly List<GameObject> CurrentEnemies = new List<GameObject>();

  
        public void SpawnEnemies(List<Enemy> enemies)
        {
            foreach (var enemy in enemies)
            {
                SpawnEnemy(enemy);
            }
        }


        public void SpawnEnemy(Enemy enemy)
        {
            var instantiatedEnemy = Instantiate(enemy.GetPrefab(), SpawnPoint, new Quaternion(0,0,0,0));

            EnemyScript enemyScript = instantiatedEnemy.AddComponent<EnemyScript>();
            enemyScript.Enemy = enemy;
            enemyScript.WayPoints = WayPoints;
            enemyScript.OnDeathDelegate += RemoveEnemy;

            CurrentEnemies.Add(instantiatedEnemy);
        }

        public void RemoveEnemy(GameObject enemy)
        {
            CurrentEnemies.Remove(enemy);
            Destroy(enemy);
        }

    }
}
