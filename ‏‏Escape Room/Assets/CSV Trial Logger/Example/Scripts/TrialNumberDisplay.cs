using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TrialNumberDisplay : MonoBehaviour {

    Text text;

	void Awake () {
        text = GetComponent<Text>();
	}
	

    // called after a trial ends
    public void UpdateTrialNumber(int num)
    {
        text.text = string.Format("Trial {0}", num);
    }
}
