using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreetyMuchEverything : MonoBehaviour
{
    public Color colorofchoiche = Color.yellow;
    MoneyText Moneytext;

    public string objectname;
    public int usages;
    public int kilo;
    public int cost;
    public Text text;
    public Text money;
    public Renderer Render;

    void Start ()
    {
        Moneytext = GetComponent<MoneyText>();
        Render = GetComponent<Renderer>();
    }

    public void OnMouseEnter()
    {
        Render.material.color = colorofchoiche;
        transform.localScale += new Vector3(0.2f, 0.2f);
        text.text = (usages) + ":Left| This is " + (objectname) + " uwu and it weighs " + (kilo) + " And it costs " + (cost);
    }

    public void OnMouseExit()   
    {
        text.text = "";
        transform.localScale -= new Vector3(0.2f, 0.2f);
        Render.material.color   = Color.white;    
    }

    public void OnMouseUpAsButton()
    {
        if (usages > 0 && MoneyText.money > cost)
        {
            text.text = "Solid buy ma guy";
            MoneyText.money -= cost;
            usages -= 1;

        if (MoneyText.money < cost)
            {
                Debug.Log("What the hell");
                text.text = "Cant let you do that starfox";
            }
        }
        if (usages <= 0)
        {
            text.text = "Were out buddy";
        }
    }
   

    public void Money()
    {
        cost = kilo * 3;
        money.text = "Money : " + MoneyText.money;
    }
    void Update ()
    {
        Money();
    }
  
}
