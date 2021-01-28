using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DelayScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip StartSong;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        //audioSource = GetComponent<AudioSource>();
        //audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
