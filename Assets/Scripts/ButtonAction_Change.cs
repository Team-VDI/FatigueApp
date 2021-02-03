using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAction_Change : MonoBehaviour
{ 
    void Update()
    {
        var colors = GetComponent<Button>().colors;
        colors.normalColor = Color.green;
        GetComponent<Button>().colors = colors;
    }

    public void ChangeColour_Wrong()
    {
        var colors = GetComponent<Button>().colors;
        colors.normalColor = Color.red;
        GetComponent<Button>().colors = colors;
    }

    public void ChangeColour_Waiting()
    {
        var colors = GetComponent<Button>().colors;
        colors.normalColor = Color.yellow;
        GetComponent<Button>().colors = colors;
    }
}
   
