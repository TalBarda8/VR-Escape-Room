using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableTestingMenu : MonoBehaviour
{
    public GameObject testingMenu;

    // Start is called before the first frame update
    void Start()
    {
        testingMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            testingMenu.SetActive(!testingMenu.activeSelf);
        }
    }
}
