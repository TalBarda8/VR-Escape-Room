using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEndGameMenu : MonoBehaviour
{
    public GameObject endGameCanvas;
    public AudioSource winSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        endGameCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "Player")
      {
            endGameCanvas.SetActive(true);
            winSoundEffect.Play();
            Time.timeScale = 0f;
      }  
    }
}
