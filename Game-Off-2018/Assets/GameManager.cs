using Assets;
using Assets.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public EnemyManager enemyManager;
    public List<Enemy> enemies;
    public LevelManager levelManager;


	// Use this for initialization
	void Start () {
       enemies = enemyManager.AllEnemies;
       levelManager = new LevelManager();

        var level = levelManager.GetAllEnemies();

       enemyManager.SpawnEnemies(level);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
