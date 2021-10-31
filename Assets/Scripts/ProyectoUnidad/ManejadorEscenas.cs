using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorEscenas : MonoBehaviour
{

    public TextMeshProUGUI Usuario;

   public void IniciarJuego()
    {
        PlayerPrefs.SetString("Player", Usuario.text);
        PlayerPrefs.SetInt("Score",0);

        SceneManager.LoadScene(1);
    }

    public void MostrarInstructivo() 
    {
        SceneManager.LoadScene(3);
    }

    public void Exit() 
    {
        Application.Quit();
    }


}
