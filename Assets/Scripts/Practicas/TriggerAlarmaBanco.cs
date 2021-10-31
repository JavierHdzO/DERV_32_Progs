using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerAlarmaBanco : MonoBehaviour
{

    AudioSource audioS;
    Light[] lucesAlarma =  new Light[4];
    bool encendido = true;



    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();

        for (int i = 0; i <lucesAlarma.Length; i++) 
        {
            lucesAlarma[i] = GameObject.Find("luzAlarma"+(i+1)
                .ToString()).GetComponent<Light>();
        }
        StartCoroutine("CorrutinaLucesAlarma");   
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        string etiqueta = other.gameObject.name;


        if (etiqueta.Equals("Persona"))
        {
            audioS.Play();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        audioS.Pause();
    }




    //Corrutina

    IEnumerator CorrutinaLucesAlarma()
    {
        while (true)
        {
            if (encendido)
            {
                for (int i = 0; i < lucesAlarma.Length; i++)
                {lucesAlarma[i].intensity = 0;}       
            }
            else 
            {
                for (int i = 0; i < lucesAlarma.Length; i++)
                {   lucesAlarma[i].intensity = 160; } 
            }
            encendido = !encendido;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
