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
            var instantiatedEnemy = Instantiate(enemy.GetPrefab(), SpawnPoint, new Quaternion(0,0,0,0));

            EnemyScript enemyScript = instantiatedEnemy.AddComponent<EnemyScript>();
            enemyScript.Enemy = enemy;
            enemyScript.WayPoints = this.WayPoints;
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
