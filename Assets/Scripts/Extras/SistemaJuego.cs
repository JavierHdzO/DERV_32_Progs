using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SistemaJuego : MonoBehaviour
{

    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_tiempo;
    public TextMeshProUGUI txt_Pistas;
    public TextMeshProUGUI Fin;
    private float tiempo = 40f;

    int puntaje;
    int pista;


    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        txt_tiempo.text = " " + tiempo;
        Fin.enabled = false;
        StartCoroutine("cronometro");

    }

    // Update is called once per frame
    void Update()
    {

        

        if (tiempo <= 0)
        {
            //txt_tiempo.text = "0";
            Fin.enabled = true;
            tiempo = Time.timeScale = 0;
            StopCoroutine("cronometro");
        }

    }

    private void FixedUpdate()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        string etiqueta = collision.gameObject.tag;
        string nombre;
        
        if (etiqueta.Equals("Dinero"))
        {
            nombre = collision.gameObject.name;
            GameObject gameObj;
            gameObj = GameObject.Find(nombre);
            Destroy(gameObj);
            puntaje++;
            txt_puntaje.text = puntaje.ToString()+"/30";
            tiempo += 10f;
        }
        if (etiqueta.Equals("Pista"))
        {
            nombre = collision.gameObject.name;
            GameObject gameObj;
            gameObj = GameObject.Find(nombre);
            Destroy(gameObj);
            pista++;
            txt_Pistas.text = pista.ToString();
            tiempo += 20f;
        }

    }

    IEnumerator cronometro()
    {
        while (true)
        {
            tiempo--;
            txt_tiempo.text = " " + tiempo.ToString("f0");
            yield return new WaitForSeconds(1.0f);
        }  
    }
}
