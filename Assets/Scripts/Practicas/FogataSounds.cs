using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogataSounds : MonoBehaviour
{

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.tag;
        audioSource.Play();

    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Pause();
        Debug.Log("Se detuvo");
    }
}
