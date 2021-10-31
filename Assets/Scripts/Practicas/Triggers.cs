using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour

    
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

    }

    private void OnTriggerStay(Collider other)
    {

        string etiqueta = other.gameObject.tag;

        

        if (etiqueta.Equals("Lampara"))
        {
            Debug.Log("Colision con " + etiqueta);
        }


    }

    private void OnTriggerExit(Collider other)
    {

    }
}
