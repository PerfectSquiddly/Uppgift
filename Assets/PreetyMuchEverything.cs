using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreetyMuchEverything : MonoBehaviour
{
    public Rigidbody2D rbdy2d;
    public string objectname;
    public int usages;
    public int kilo;
    public int dublons;
    private int currentmoney = 20;
    public Text text;
    public Text money;
    public Renderer Render;

	void Start ()
    {
        rbdy2d = GetComponent<Rigidbody2D>();
        Render = GetComponent<Renderer>();
    }

    public void OnMouseEnter()
    {
        Render.material.color = Color.yellow;
        text.text = (usages) + ":Left| This is " + (objectname) + " uwu and it weighs " + (kilo) + " And it costs " + (dublons);
    }

    public void OnMouseExit()   
    {
        text.text = "";
       Render.material.color = Color.white;    
    }

    public void OnMouseUpAsButton()
    {
        if (usages > 0)
        {
            usages -= 1;
            text.text = "Solid buy ma guy";
            currentmoney -= dublons;
        }
        if(usages <= 0)
        {
            text.text = "Were out buddy";
        }
    }
   

    public void Money()
    {
        dublons = kilo * 3;
        money.text = "Money : " + currentmoney;
    }
    void Update ()
    {
        Money();
    }
  
}
