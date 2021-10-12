using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pagePrint : MonoBehaviour
{
    public GameObject page;
    public Transform spawnTransform;
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreatePage", 3f, 20f);
    }

    void CreatePage() {
        Debug.Log("spawned a page");
        Instantiate(page, spawnTransform.position, spawnTransform.rotation);
        if(!sound.isPlaying) {
            sound.Play();
        }
    }
}
