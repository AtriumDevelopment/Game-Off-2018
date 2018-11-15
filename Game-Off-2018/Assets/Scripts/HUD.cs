using System.Collections.Generic;
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Button Button;
    private Dictionary<Vector3, GameObject> _objects = new Dictionary<Vector3, GameObject>();
    private Vector3 _selectedPosition;

    // Use this for initialization
    void Start ()
    {
        var panel = GameObject.Find("OptionsPanel");

        var test1 = Instantiate(Button);
        test1.GetComponentInChildren<Text>().text = "Place Wall";
        test1.transform.SetParent(panel.transform);
        test1.onClick.AddListener(() => CreateObject("Wall"));

        var test2 = Instantiate(Button);
        test2.GetComponentInChildren<Text>().text = "Place Tower";
        test2.transform.SetParent(panel.transform);
        test2.onClick.AddListener(() => CreateObject("Tower"));
    }

    public void NewPositionSelected(Vector3 position)
    {
        _selectedPosition = position;

        //Debug info
        GetComponentInChildren<Text>().text = position.ToString();
    }

    public void CreateObject(string type)
    {
        if (type == "Wall")
        {
            var prefab = Resources.Load<GameObject>("Wall");
            Instantiate(prefab).transform.position = _selectedPosition;
        }

        if (type == "Tower")
        {
            var prefab = Resources.Load<GameObject>("Tower");
            var tower = Instantiate(prefab);
            tower.transform.position = _selectedPosition + prefab.transform.position;
        }
    }
}
