using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    public Transform Target;

    public float speed = 10;

	// Update is called once per frame
	void Update () {
	    // The step size is equal to speed times frame time.
	    float step = speed * Time.deltaTime;

	    // Move our position a step closer to the target.
	    transform.position = Vector3.MoveTowards(transform.position, Target.position, step);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
