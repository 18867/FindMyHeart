using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{

    public GameObject heartColor;

    // Start is called before the first frame update

    public void ActivateHeart()
    {
        heartColor.gameObject.SetActive(true);
        GameController.instance.count++;
        AudioManager.instance.audioSource.PlayOneShot(AudioManager.instance.audios[0]);
            
        
    }

}
