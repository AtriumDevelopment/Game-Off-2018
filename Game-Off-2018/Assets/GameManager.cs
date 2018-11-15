using System.Collections.Generic;
using Assets;
using Assets.Enemy;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public readonly EnemyManager EnemyManager = new EnemyManager();
    public readonly LevelManager LevelManager = new LevelManager();
    public Transform Grid;

    // Use this for initialization
    private void Start()
    {
        EnemyManager.SpawnPoint = Grid.GetChild(1).transform.position;
        EnemyManager.WayPoints = new List<Vector3> {Grid.GetChild(3599).transform.position};
    }

    // Update is called once per frame
    private void Update()
    {
        if (EnemyManager.CurrentEnemies.Count == 0)
        {
            EnemyManager.SpawnEnemies(LevelManager.GetAllEnemies());
            LevelManager.Advance();
        }
    }
}