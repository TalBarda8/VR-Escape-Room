using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThirdKeySpot : MonoBehaviour
{
    public GameObject rightDoor;
    public GameObject leftDoor;

    public AudioSource keyPlacedSoundEffect;
    public XRGrabInteractable keyGrabInteractable;

    //[SerializeField] private Animator leftDoorAnimator = null;
    //[SerializeField] private string leftDoorOpen = "LeftDoorOpen";

    private void Start()
    {
        //leftDoorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key3")
        {
            keyPlacedSoundEffect.Play();
            keyGrabInteractable.enabled = false;
            rightDoor.SetActive(false);
            leftDoor.SetActive(false);
            //leftDoorAnimator.Play(leftDoorOpen, 0, 0.0f);
        }
    }
}
