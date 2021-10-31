using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinJuegoScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI usu;
    [SerializeField]
    TextMeshProUGUI punt;

    // Start is called before the first frame update
    void Start()
    {
        string usuario = PlayerPrefs.GetString("usu");
        int puntaje = PlayerPrefs.GetInt("score");

        usu.text = usuario;
        punt.text = puntaje.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
