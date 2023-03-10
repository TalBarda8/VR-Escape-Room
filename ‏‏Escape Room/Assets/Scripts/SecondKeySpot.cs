using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SecondKeySpot : MonoBehaviour
{
    public GameObject thirdKeySpot;
    public GameObject thirdRiddleCanvas;
    public TextMeshProUGUI thirdRiddle;

    public AudioSource keyPlacedSoundEffect;
    public XRGrabInteractable keyGrabInteractable;

    private void Start()
    {
        thirdKeySpot.SetActive(false);
        thirdRiddleCanvas.SetActive(false);
        thirdRiddle.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key2")
        {
            thirdKeySpot.SetActive(true);
            thirdRiddleCanvas.SetActive(true);
            thirdRiddle.enabled = true;

            keyPlacedSoundEffect.Play();
            keyGrabInteractable.enabled = false;
        }
    }
}
