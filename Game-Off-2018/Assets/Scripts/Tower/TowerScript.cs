using UnityEngine;

public class TowerScript : MonoBehaviour
{
    private GameManager _gameManager;
    private Transform _target;
    private readonly int attackSpeed = 100;

    public GameObject Projectile;
    private readonly int range = 50;
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
            _target = _gameManager.EnemyManager.CurrentEnemies[0].transform;
        else if (_target != null)
        {
            ticks++;
            if (Vector3.Distance(transform.position, _target.position) <= range && ticks >= attackSpeed)
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