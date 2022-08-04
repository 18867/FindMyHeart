using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public int count = 0;
    public Canvas gameOverCanvas;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (count >= 7)
        {
            AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.audios[1]);
            gameOverCanvas.gameObject.SetActive(true);
        }
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quited");
    }
}
