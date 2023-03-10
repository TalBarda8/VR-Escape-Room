using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour {

    public ExampleExperimentController experimentController;

	// Use this for initialization
	void Start () {
        MoveSphere();
	}

    // Update is called once per frame
    void Update()
    {
        // If mouse button clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Check if sphere was clicked
            if (WasClicked())
            {
                // Tell the experiment controller the sphere was clicked, so it can log the trial
                experimentController.SphereClicked(gameObject.transform.position);
                // Move to new position
                MoveSphere();                
            }
        }
    }

    bool WasClicked()
    {
        // raycast from camera to click location
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            return true;
        }else
        {
            return false;
        }

    }

    void MoveSphere()
    {
        // generate random x, y position
        float x = Random.Range(-3F, 3F);
        float y = Random.Range(-3F, 3F);

        // set position to new x, y keeps z
        Vector3 oldPos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(x, y, oldPos.z);
    }
}
