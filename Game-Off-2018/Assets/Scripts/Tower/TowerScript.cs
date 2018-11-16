using UnityEngine;

public class TowerScript : MonoBehaviour
{
    private readonly int attackSpeed = 100;
    private readonly int range = 20;
    private GameManager _gameManager;
    private Transform _target;

    public GameObject Projectile;
    private int ticks;

    // Use this for initialization
    private void Start()
    {
        _gameManager = GameObject.Find("World").GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (_target == null && _gameManager.EnemyManager.CurrentEnemies.Count > 0)
        {
            _target = _gameManager.EnemyManager.CurrentEnemies[0].transform;
        }
        else if (_target != null)
        {
            if (Vector3.Distance(transform.position, _target.position) <= range)
            {
                ticks++;
                if (ticks >= attackSpeed)
                {
                    ticks = 0;
                    var bullet = Instantiate(Projectile);
                    bullet.transform.position = transform.position;
                    var projectileScript = bullet.GetComponent<ProjectileScript>();
                    projectileScript.Target = _target;
                }
            }
        }
    }
}