using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    [SerializeField]
    private Texture2D cursorTexture;
    private Vector2 cursorHotspot;
    private Vector2 mousePos;

    [SerializeField]
    private Text getReadyText;

    [SerializeField]
    private GameObject resultsPanel;
    public GameObject start_button;

    [SerializeField]
    private Text scoreText, targetHitText, shotsFiredText, accuracyText;

    public static int score, targetHit;
    private float shotsFired;
    private float accuracy;
    private int targetAmount;

    private Vector2 targetRandomPostition;

    //Start is called before the first frame update
    void Start()
    {
        cursorHotspot = new Vector2(cursorTexture.width/2, cursorTexture.height/2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
        
        resultsPanel.SetActive(false);
        start_button.SetActive(true);

        getReadyText.gameObject.SetActive(false);

        targetAmount = 10;
        score = 0;
        shotsFired = 0;
        targetHit = 0;
        accuracy = 0f;
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shotsFired += 1f;
        }
    }

    private IEnumerator GetReady()
    {
        start_button.SetActive(false);

        for (int i = 3; i >= 1; i--)
        {
            getReadyText.text = "Gatavojies uzsākt testu! \n" + i.ToString();
            yield return new WaitForSeconds(1f);
        }
        getReadyText.text = "Sāc!";
        yield return new WaitForSeconds(1f);

        StartCoroutine(SpawnTargets());
    }

    private IEnumerator SpawnTargets()
    {
        getReadyText.gameObject.SetActive(false);

        score = 0;
        shotsFired = 0;
        targetHit = 0;
        accuracy = 0f;

        for (int i = targetAmount; i>=0; i--)
        {
            targetRandomPostition = new Vector2(Random.Range(-2f, 2f), Random.Range(-1f, 1f));
            Instantiate(target, targetRandomPostition, Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }

        resultsPanel.SetActive(true);
        scoreText.text = "Punktu skaits: " + score;
        Debug.Log("END SCORE : " + score);
        targetHitText.text = "Trāpīti mērķi: " + targetHit + "/" + targetAmount;
        shotsFiredText.text = "Izšauti šāvieni: " + shotsFired;
        accuracy = targetHit / shotsFired * 100f;
        Debug.Log("END ACCURACY: " + accuracy);
        accuracyText.text = "Precizitāte: " + accuracy.ToString("N2") + " %";
    }

    public void StartGetReadyCoroutine()
    {
        resultsPanel.SetActive(false);
        getReadyText.gameObject.SetActive(true);
        StartCoroutine(GetReady());
    }
    
}