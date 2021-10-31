using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorFin : MonoBehaviour
{

    [SerializeField]
    public TextMeshProUGUI NombreUsuario;

    [SerializeField]
    public TextMeshProUGUI TXTPuntuaje;

    [SerializeField]
    public TextMeshProUGUI txtResultado;

    // Start is called before the first frame update
    void Start()
    {

        string usuario = PlayerPrefs.GetString("Player");
        NombreUsuario.text = usuario.ToString();

        int score = PlayerPrefs.GetInt("Score");
        TXTPuntuaje.text = score.ToString();

        string resultado = PlayerPrefs.GetString("result");
        txtResultado.text = resultado;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void JugarNuevamente()
    {

        SceneManager.LoadScene(0);
    }

}
