using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HideWithButton : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;

    public GameObject Object4;
    public GameObject Object5;

    public void HideObjects()
    {
        Object1.SetActive(false);
        Object2.SetActive(false);
        Object3.SetActive(false);
    }

    public void ShowObjects()
    {
        Object4.SetActive(true);
        Object5.SetActive(true);
    }
}
