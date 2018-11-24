using System.Collections.Generic;
using Assets.Enemy.Modifiers;
using Assets.Scripts.Tower.Targeting;
using UnityEngine;

namespace Assets.Scripts.Tower.Attacks
{
    public abstract class Attack : MonoBehaviour
    {
        private GameManager _gameManager;
        private int _ticks;

        public int _attackSpeed = 100;
        public int _attackRange = 10;

        public List<EnemyModifier> Effects { get; set; }

        private void Start()
        {
            _gameManager = GameObject.Find("World").GetComponent<GameManager>();
            if (gameObject.GetComponent<Targeting.Targeting>() == null)
            {
                gameObject.AddComponent<DefaultTargeting>();
            }
        }

        private void Update()
        {
            var Targeting = gameObject.GetComponent<Targeting.Targeting>();
            if (Targeting.GetFirstTarget() != null && Vector3.Distance(transform.position, Targeting.GetFirstTarget().position) <= _attackRange)
            {
                _ticks++;
                if (_ticks >= _attackSpeed)
                {
                    _ticks = 0;
                    var prefab = Resources.Load<GameObject>("Projectile");
                    var bullet = Instantiate(prefab);
                    bullet.transform.position = transform.position;
                    var projectileScript = bullet.GetComponent<ProjectileScript>();
                    projectileScript.Targets = Targeting.GetTargets();
                }
            }
        }
    }
}
