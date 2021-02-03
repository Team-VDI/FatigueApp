using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HideObject : MonoBehaviour
{
    public GameObject TextObj_A_Hide;
    public GameObject HideObj;
    public GameObject ShowObj_1;
    public GameObject ShowObj_2;

    public float time; //Seconds to read the text

    void Start()
    {
        Invoke("Hide", time);
    }

    void Hide()
    {
        TextObj_A_Hide.SetActive(false);
        HideObj.SetActive(false);
        ShowObj_1.SetActive(true);
        ShowObj_2.SetActive(true);
    }

}