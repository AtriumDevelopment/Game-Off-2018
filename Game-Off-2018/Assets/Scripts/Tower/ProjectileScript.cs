using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Assets.Enemy;
using Assets.Enemy.Modifiers;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    public List<Transform> Targets;
    public float speed = 50;

 

    // Update is called once per frame
    void Update () {
	    if (Targets.Count == 0)
	        Destroy(gameObject);
        else if (Targets[0] == null)
	        Targets.Remove(Targets[0]);
        else
        {
	        // The step size is equal to speed times frame time.
	        float step = speed * Time.deltaTime;

	        // Move our position a step closer to the target.
	        transform.position = Vector3.MoveTowards(transform.position, Targets[0].position, step);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        var enemy = other.gameObject.GetComponent<EnemyScript>();
        if ( enemy != null)
        {
            enemy.EnemyModifiers.Add(new DamageModifier(1, 100));
        }
    }
}
