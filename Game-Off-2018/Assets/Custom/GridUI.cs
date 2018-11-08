using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GridUI : MonoBehaviour
{
    public GameObject prefab;
    public Transform container;

    // Use this for initialization
    void Start ()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject go = Instantiate(prefab);
            go.transform.SetParent(container,false);
            go.transform.position = new Vector3(i % 10 * 1.5f, 0.1f, i / 10 * 1.5f);
        }
    }
	
}
