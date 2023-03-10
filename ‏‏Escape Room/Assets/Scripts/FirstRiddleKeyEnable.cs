using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FirstRiddleKeyEnable : MonoBehaviour
{
    public GameObject key;
    public XRGrabInteractable keyGrabInteractable;

    public AudioSource keyEnableSoundEffect;

    private void Start()
    {
        key.SetActive(false);
        keyGrabInteractable.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            keyEnableSoundEffect.Play();
            key.SetActive(true);
            keyGrabInteractable.enabled = true;
        }
    }
}
