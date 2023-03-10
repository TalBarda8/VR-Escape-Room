using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class ThirdRiddleKeyEnable : MonoBehaviour
{
    public GameObject key;
    public XRGrabInteractable keyGrabInteractable;

    public AudioSource keyEnableSoundEffect;

    public Dropdown hundredsDropdown;
    public Dropdown tensDropdown;
    public Dropdown onesDropdown;

    private bool enteredIf = false;

    private void Start()
    {
        key.SetActive(false);
        keyGrabInteractable.enabled = false;
    }

    private void Update()
    {
        if (hundredsDropdown.value == 0 && tensDropdown.value == 3 && onesDropdown.value == 3) 
        {
            if (!enteredIf)
            {
                keyEnableSoundEffect.Play();
                key.SetActive(true);
                keyGrabInteractable.enabled = true;
                enteredIf = true;
            }
        }
    }
}
