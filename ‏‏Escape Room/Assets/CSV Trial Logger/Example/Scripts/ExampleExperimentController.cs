using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleExperimentController : MonoBehaviour {

    // our trial logger component
    TrialLogger trialLogger;

    // a component for displaying the trial number on the screen
    public TrialNumberDisplay trialNumDisplay;

    // participant id (string)
    public string participantID = "0001";

    // max number of trials
    public int numberOfTrials = 10;


    // Use this for initialization
    void Start()
    {
        // define the names of the custom datapoints we want to log
        // trial number, participant ID, trial start/end time are logged automatically
        List<string> columnList = new List<string> { "sphere_x", "sphere_y" };

        // initialise trial logger
        trialLogger = GetComponent<TrialLogger>();
        trialLogger.Initialize(participantID, columnList);

        // here we start the first trial immediately, you can start it at any time
        trialLogger.StartTrial();

        // now we update the trial number on screen
        trialNumDisplay.UpdateTrialNumber(trialLogger.currentTrialNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }


    // This function is called when we click the sphere
    public void SphereClicked(Vector3 spherePosition)
    {
        // at any time before we end the trial, we can assign our observations to the 'trial' dictionary
        // e.g.
        trialLogger.trial["sphere_x"] = spherePosition.x.ToString();
        trialLogger.trial["sphere_y"] = spherePosition.y.ToString();

        // now we end the trial, which stores data for this trial, then increments the trial number
        trialLogger.EndTrial();

        // if we are at the max number of trials, we quit the game
        // note: CSV is saved on exit automatically
        if (trialLogger.currentTrialNumber >= numberOfTrials) QuitGame();

        // here we could have some time for feedback, loading the next trial etc
        // but we will just start the next trial immediately
        trialLogger.StartTrial();

        // now we update the trial number on screen
        trialNumDisplay.UpdateTrialNumber(trialLogger.currentTrialNumber);
    }


    public void QuitGame()
    {
        // save any game data here
        #if UNITY_EDITOR
            // Application.Quit() does not work in the editor so
            // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
