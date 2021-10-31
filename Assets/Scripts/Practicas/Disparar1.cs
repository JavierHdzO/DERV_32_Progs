using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar1 : MonoBehaviour
{

    [SerializeField]
    GameObject posSpawner;
    [SerializeField]
    GameObject bullet;
    AudioSource audioSource;

     
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.Play();
            GameObject bull = Instantiate(bullet, posSpawner.transform.position,
                posSpawner.transform.rotation);

            Destroy(bull, 2.5f);
        }
    }
}
