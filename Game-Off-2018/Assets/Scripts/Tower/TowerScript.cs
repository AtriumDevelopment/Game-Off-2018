using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    public GameObject Projectile;
    private int attackSpeed = 100;
    private int range = 10;
    private Transform target;

    private int ticks;
	// Use this for initialization
	void Start () {
		target = GameObject.Find("Body").transform;
    }
	
	// Update is called once per frame
	void Update ()
	{
	    ticks++;
	    if (Vector3.Distance(transform.position,target.position) <= range && ticks >= attackSpeed)
	    {
	        ticks = 0;
	        var bullet = Instantiate(Projectile);
	        bullet.transform.position = transform.position;
	        var projectileScript = bullet.GetComponent<ProjectileScript>();
	        projectileScript.Target = target;
	    }
	        
	}
}
