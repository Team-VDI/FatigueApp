using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test_TimerSwitch : MonoBehaviour
{
    public RawImage timedPanel;
    public float startTime;

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;

        if (startTime >= 0)
        {
            timedPanel.GetComponent<RawImage>().color = new Color32(0,255,0,100);
        }

        if (startTime >= 7f)
        {
            timedPanel.GetComponent<RawImage>().color = new Color32(255,0,0,100);
        }

        if (startTime >= 10f){
            startTime = 0;
        }
    }
}
