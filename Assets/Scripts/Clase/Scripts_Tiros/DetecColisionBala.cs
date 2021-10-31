using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DetecColisionBala : MonoBehaviour
{
    //[SerializeField]
    public TextMeshProUGUI txt_puntaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        string tag = collision.gameObject.tag;

        if (tag.Equals("Municion"))
        {
            int temp = Convert.ToInt32(txt_puntaje.text) + 1;
            txt_puntaje.text = temp.ToString();
            
            string name = collision.gameObject.name;

            GameObject bala = GameObject.Find(name);

            Destroy(bala);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        /*
        string tag = other.gameObject.tag;

        if (tag.Equals("Municion"))
        {
            int temp = Convert.ToInt32(txt_puntaje.text) + 1;
            txt_puntaje.text = temp.ToString();
        }
        */
    }

}
