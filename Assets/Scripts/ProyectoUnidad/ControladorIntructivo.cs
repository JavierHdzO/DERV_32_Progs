using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorIntructivo : MonoBehaviour
{
    [SerializeField]
    GameObject ImagenControl;
    [SerializeField]
    GameObject ImagenObj;

    // Start is called before the first frame update
    private void Awake()
    {

        ImagenControl = GameObject.Find("ImagenControl");
        ImagenObj = GameObject.Find("ImagenObj");
    }

    private void Start()
    {
        ImagenObj.SetActive(false);
  
    }

    public void volverInicio() 
    {
        SceneManager.LoadScene(0);
        
    }


    public void mostrarControles() 
    {
        ImagenObj.SetActive(false);
        ImagenControl.SetActive(true);
        
    }


    public void mostrarObjetivos()
    {
        ImagenControl.SetActive(false);
        ImagenObj.SetActive(true);
    }
}
