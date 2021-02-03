using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowObject : MonoBehaviour
{
    public GameObject item;

    public void Show()
    {
        item.SetActive(true);
    }

}