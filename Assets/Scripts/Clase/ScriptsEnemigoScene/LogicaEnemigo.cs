using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour
{
    public GameObject personaje; //personaje a atacar

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (personaje != null)
        {
            transform.LookAt(personaje.transform.position);
        }
    }


    

}
