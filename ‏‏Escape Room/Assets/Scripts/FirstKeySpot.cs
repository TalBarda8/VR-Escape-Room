using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FirstKeySpot : MonoBehaviour
{
    public GameObject secondKeySpot;
    public GameObject thirdKeySpot;
    public TextMeshProUGUI secondRiddle;
    public TextMeshProUGUI thirdRiddle;
    public GameObject thirdRiddleCanvas;

    public AudioSource keyPlacedSoundEffect;
    public XRGrabInteractable keyGrabInteractable;

    public XRGrabInteractable whiteStoneHorse;
    public XRGrabInteractable whiteStoneRook;
    public XRGrabInteractable whiteStonePawn1;
    public XRGrabInteractable whiteStonePawn2;
    public XRGrabInteractable whiteStonePawn3;
    public XRGrabInteractable whiteStoneBishop;
    public XRGrabInteractable whiteStoneQueen;
    public XRGrabInteractable whiteStoneKing;

    private void Start()
    {
        secondKeySpot.SetActive(false);
        thirdKeySpot.SetActive(false);
        thirdRiddleCanvas.SetActive(false);
        secondRiddle.enabled = false;
        thirdRiddle.enabled = false;

        whiteStoneHorse.enabled = false;
        whiteStoneRook.enabled = false;
        whiteStonePawn1.enabled = false;
        whiteStonePawn2.enabled = false;
        whiteStonePawn3.enabled = false;
        whiteStoneBishop.enabled = false;
        whiteStoneQueen.enabled = false;
        whiteStoneKing.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key1")
        {
            keyPlacedSoundEffect.Play();
            keyGrabInteractable.enabled = false;
            secondKeySpot.SetActive(true);
            secondRiddle.enabled = true;

            whiteStoneHorse.enabled = true;
            whiteStoneRook.enabled = true;
            whiteStonePawn1.enabled = true;
            whiteStonePawn2.enabled = true;
            whiteStonePawn3.enabled = true;
            whiteStoneBishop.enabled = true;
            whiteStoneQueen.enabled = true;
            whiteStoneKing.enabled = true;
        }
    }
}
