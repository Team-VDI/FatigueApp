using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HideObjects : MonoBehaviour
{
    public GameObject objektinsACTIVATE;
    public GameObject objektins1;

    public GameObject podzinaACTIVATE;
    public GameObject podzina1ACTIVATE;
    public GameObject podzina2;
    public GameObject podzina3;

    public void hideThoseObjectsPls()
    {
        objektinsACTIVATE.SetActive(true);
        objektins1.SetActive(false);

        podzinaACTIVATE.SetActive(true);
        podzina1ACTIVATE.SetActive(true);
        podzina2.SetActive(false);
        podzina3.SetActive(false);
    }
}