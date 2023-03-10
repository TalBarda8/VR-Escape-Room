using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public TMP_Text timeInSecondsGameEndMenu;
    private float startTime;
    private bool gameEnded = false;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded)
        {
            return;
        }

        float timeCounter = Time.time - startTime;
        string minutes = ((int) timeCounter / 60).ToString();
        string seconds = (timeCounter % 60).ToString("f0");

        timerText.text = minutes + ":" + seconds;
        timeInSecondsGameEndMenu.text = timeCounter.ToString("f0") + " seconds";
        PlayerPrefs.SetString("Score", timeCounter.ToString("f0"));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameEnded = true;
            timerText.color = Color.yellow;
        }
    }
}
