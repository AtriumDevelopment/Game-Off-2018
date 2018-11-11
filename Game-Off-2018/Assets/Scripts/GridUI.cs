using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class GridUI : MonoBehaviour
{
    public Button button;
    public Transform container;
    public Canvas HUDCanvas;
    private HUD HUD;


    private int area = 60;

    // Use this for initialization
    private void Start ()
    {
        for (var i = 0; i < area * area; i++)
        {
            var go = Instantiate(button);
            go.transform.SetParent(container,false);
            go.transform.position = new Vector3(i % area * 1.5f - 44.275f, 0.1f, i / area * 1.5f - 44.275f);
            go.onClick.AddListener(Clicked);
        }

        HUD = HUDCanvas.GetComponent<HUD>();
    }

    private void Clicked()
    {
        HUD.NewPositionSelected(EventSystem.current.currentSelectedGameObject.transform.position);
    }
	
}
