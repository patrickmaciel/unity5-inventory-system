using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    private Item item;
    private string data;
    private GameObject tooltip;

    void Start()
    {
        tooltip = GameObject.Find("Tooltip");    
        tooltip.SetActive(false);
    }

    void Update()
    {
        if (tooltip.activeSelf)
        {
            tooltip.transform.position = Input.mousePosition;
        }
    }

    public void Activate(Item item)
    {
        this.item = item;
        ConstructDataString();
        tooltip.SetActive(true);
    }

    public void Deactivate()
    {
        tooltip.SetActive(false);   
    }

    public void ConstructDataString()
    {
        data = "<color=#FFF><b>" + item.Title + "</b>\n\n" 
            + item.Description + "\n" 
            + "<b>Power: </b>" + item.Power + "\n"
            + "<b>Defense: </b>" + item.Vitality + "\n"
            + "<b>Vitality: </b>" + item.Defense + "\n"
            + "</color>";
        tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
    }
}
