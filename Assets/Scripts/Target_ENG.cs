using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_ENG: MonoBehaviour
{
    void start ()
    {
        Destroy(gameObject, 1f);
    }

    public void OnMouseDown()
    {
        GameControl_ENG.score += 10;
        GameControl_ENG.targetHit += 1;
        Destroy(gameObject);
        Debug.Log("Target hit");
    }
}