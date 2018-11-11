using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Button Button;
    private Dictionary<Vector3, GameObject> objects = new Dictionary<Vector3, GameObject>();
    private Vector3 selectedPosition;

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

    }

    public void NewPositionSelected(Vector3 position)
    {
        selectedPosition = position;
        GetComponentInChildren<Text>().text = position.ToString();
    }

    public void CreateObject(string type)
    {
        if (type == "Wall")
        {
            var go = Resources.Load<GameObject>("Wall");
            Instantiate(go).transform.position = selectedPosition;
        }
    }
}
