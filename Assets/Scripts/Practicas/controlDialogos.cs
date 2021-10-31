using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine;

public class controlDialogos : MonoBehaviour
{
    public GameObject dialogo;
    public TextMeshProUGUI txtDialogo;
    public Frase[] dialogoPersonajes;
    string etiqueta;
    // Start is called before the first frame update
    void Start()
    {
        dialogo.SetActive(false);
    }

    public IEnumerator Decir(Frase[] _dialogo) 
    {
        dialogo.SetActive(true);

        for (int i = 0; i < _dialogo.Length; i++)
        {
            txtDialogo.text = _dialogo[i].texto;
            yield return new WaitForSeconds(1.5f);
        }
        dialogo.SetActive(false);
        if (this.name.Equals("contenedorThief")) 
        {
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        etiqueta = other.gameObject.tag;
        if (etiqueta.Equals("Player"))
        {
            StartCoroutine(Decir(dialogoPersonajes)); 
        }   
    }




}

[System.Serializable]
public class Frase 
{
    public string texto;
}
