using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target: MonoBehaviour
{
    void start ()
    {
        Destroy(gameObject, 1f);
    }

    public void OnMouseDown()
    {
        GameControl.score += 10;
        GameControl.targetHit += 1;
        Destroy(gameObject);
        Debug.Log("Target hit");
    }
}