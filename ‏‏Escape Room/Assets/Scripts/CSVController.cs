using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVController : MonoBehaviour
{
    TrialLogger trialLogger;

    public string participantID = "0001";

    // Start is called before the first frame update
    void Start()
    {
        List<string> columnList = new List<string> { "totalGameTime" };

        trialLogger = GetComponent<TrialLogger>();
        trialLogger.Initialize(participantID, columnList);

        trialLogger.StartTrial();
    }

    public void totalGameTime()
    {
        trialLogger.trial["totalGameTime"] = PlayerPrefs.GetString("Score");
    }
}
