using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pagePrint : MonoBehaviour
{
    public GameObject page;
    public Transform spawnTransform;
    public AudioSource sound;
    public AudioSource taskTwoAudio;
    public GameObject TaskOneMark;
    public GameObject TaskTwoMark;
    public GameObject TasksComplete;
    private bool isTaskTwoComplete = false;
    private bool isPrinting = false;


    void OnTriggerEnter (Collider other) {
        Debug.Log($"{gameObject.name} is colliding with {other.name}");
        if(!isPrinting && other.name == "ExampleAvatar") {
            if(!isTaskTwoComplete) {
                UpdateTasks();
            }
            isTaskTwoComplete = true;
            isPrinting = true;
            InvokeRepeating("SetPrintingFalse", 0f, 3f);
            if(!sound.isPlaying) {
                sound.Play();
            }
            CreatePage();
        }
    }

    void SetPrintingFalse() {
        isPrinting = false;
    }

    void CreatePage() {
        Instantiate(page, spawnTransform.position, spawnTransform.rotation);
    }

    void UpdateTasks() {
        TaskTwoMark.SetActive(true);
        if(TaskOneMark.activeSelf) {
            TasksComplete.SetActive(true);
        }
        if(!taskTwoAudio.isPlaying) {
            taskTwoAudio.Play();
        }
    }
    
}
