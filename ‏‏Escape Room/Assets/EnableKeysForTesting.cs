using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class EnableKeysForTesting : MonoBehaviour
{
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;

    public XRGrabInteractable key1GrabInteractable;
    public XRGrabInteractable key2GrabInteractable;
    public XRGrabInteractable key3GrabInteractable;


    // Start is called before the first frame update
    void Start()
    {
        key1.SetActive(false);
        key2.SetActive(false);
        key3.SetActive(false);
        key1GrabInteractable.enabled = false;
        key2GrabInteractable.enabled = false;
        key3GrabInteractable.enabled = false;
    }

    public void enableFirstKey()
    {
        key1.SetActive(true);
        key1GrabInteractable.enabled = true;
    }

    public void enableSecondKey()
    {
        key2.SetActive(true);
        key2GrabInteractable.enabled = true;
    }

    public void enableThirdKey()
    {
        key3.SetActive(true);
        key3GrabInteractable.enabled = true;
    }
}
