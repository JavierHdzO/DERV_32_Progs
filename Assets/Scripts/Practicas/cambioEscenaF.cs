using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscenaF : MonoBehaviour
{
    public TextMeshProUGUI pistas;
    int cantPista;
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
        cantPista = int.Parse(pistas.text);
        Debug.Log(cantPista);
        if (cantPista == 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
