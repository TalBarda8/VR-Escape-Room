using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{
    public TMP_Text firstPlaceText;
    public TMP_Text secondPlaceText;
    public TMP_Text thirdPlaceText;

    private int firstPlaceScore = 1000;
    private int secondPlaceScore = 1000;
    private int thirdPlaceScore = 1000;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("FirstPlaceScore"))
        {
            PlayerPrefs.SetString("FirstPlaceScore", firstPlaceScore.ToString());
            PlayerPrefs.SetString("SecondPlaceScore", firstPlaceScore.ToString());
            PlayerPrefs.SetString("ThirdPlaceScore", firstPlaceScore.ToString());
            PlayerPrefs.SetString("Score", 2000.ToString());
        }

        UpdateLastScore();

        firstPlaceText.text = "First Place: " + PlayerPrefs.GetString("FirstPlaceScore") + " seconds.";
        secondPlaceText.text = "Second Place: " + PlayerPrefs.GetString("SecondPlaceScore") + " seconds.";
        thirdPlaceText.text = "Third Place: " + PlayerPrefs.GetString("ThirdPlaceScore") + " seconds.";
    }

    private void UpdateLastScore()
    {
        int score = int.Parse(PlayerPrefs.GetString("Score"));
        firstPlaceScore = int.Parse(PlayerPrefs.GetString("FirstPlaceScore"));
        secondPlaceScore = int.Parse(PlayerPrefs.GetString("SecondPlaceScore"));
        thirdPlaceScore = int.Parse(PlayerPrefs.GetString("ThirdPlaceScore"));

        if (score < thirdPlaceScore) 
        {
            thirdPlaceScore = score;

            if (score < secondPlaceScore)
            {
                thirdPlaceScore = secondPlaceScore;
                secondPlaceScore = score;

                if (score < firstPlaceScore)
                {
                    secondPlaceScore = firstPlaceScore;
                    firstPlaceScore = score;
                }
            }
        }

        PlayerPrefs.SetString("FirstPlaceScore", firstPlaceScore.ToString());
        PlayerPrefs.SetString("SecondPlaceScore", secondPlaceScore.ToString());
        PlayerPrefs.SetString("ThirdPlaceScore", thirdPlaceScore.ToString());
    }
}
