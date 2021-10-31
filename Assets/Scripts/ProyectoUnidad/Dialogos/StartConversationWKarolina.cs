using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartConversationWKarolina : MonoBehaviour
{
    [SerializeField]
    CrearDialogoProject dialogo;
    public GameObject mainContainer;
    public GameObject missionContainer;
    public Image imageCharacter;
    public TextMeshProUGUI textMesh;
    public TextMeshProUGUI currentMission;
    public GameObject Mario;
    int indice = 0;
    bool isOnTrigger;
    bool isItRunning;

    private void Awake()
    {
        mainContainer = GameObject.Find("ContenedorConversacion");
        imageCharacter = mainContainer.GetComponentInChildren<Image>();
        textMesh = mainContainer.GetComponentInChildren<TextMeshProUGUI>();
        missionContainer = GameObject.Find("ContenedorMision");
        currentMission = missionContainer.GetComponentInChildren<TextMeshProUGUI>();
        Mario = GameObject.Find("Mario");
    }
    void Start()
    {
        mainContainer.SetActive(false);
        isOnTrigger = false;
        missionContainer.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("CuerpoPersonaje"))
        {
            mainContainer.SetActive(true);
            textMesh.text = dialogo.conversacionKarolina[indice].nombrePersonaje + ": " + dialogo.conversacionKarolina[indice].Message;
            imageCharacter.sprite = dialogo.conversacionKarolina[indice].CharacterImage;
            textMesh.maxVisibleCharacters = 0;
            StopAllCoroutines();
            StartCoroutine("mostrarTexto");

            isOnTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isOnTrigger = false;
        mainContainer.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if ((isOnTrigger) && (Input.GetKeyDown(KeyCode.E)) && (indice < dialogo.conversacionKaroLength() - 1) && (!isItRunning))
        {
            indice++;
            textMesh.text = dialogo.conversacionKarolina[indice].nombrePersonaje + ": " + dialogo.conversacionKarolina[indice].Message;
            imageCharacter.sprite = dialogo.conversacionKarolina[indice].CharacterImage;

            textMesh.maxVisibleCharacters = 0;
            StopAllCoroutines();
            StartCoroutine("mostrarTexto");
        }
        if ((isOnTrigger) && (Input.GetKeyDown(KeyCode.Q)) && (indice > 0) && (!isItRunning))
        {
            indice--;
            textMesh.text = dialogo.conversacionKarolina[indice].nombrePersonaje + ": " + dialogo.conversacionKarolina[indice].Message;
            imageCharacter.sprite = dialogo.conversacionKarolina[indice].CharacterImage;

            textMesh.maxVisibleCharacters = 0;
            StopAllCoroutines();
            StartCoroutine("mostrarTexto");
        }

        if (indice == dialogo.conversacionKaroLength() - 1)
        {
            missionContainer.SetActive(true);
            currentMission.SetText("Misión: Trae a Mario a la ubicación de Karolina");
            Mario.SetActive(true);
            StartCoroutine("eliminarTrigger");

        }
    }

    IEnumerator mostrarTexto()
    {
        isItRunning = true;
        while (true)
        {
            textMesh.maxVisibleCharacters += 1;

            if (textMesh.maxVisibleCharacters == textMesh.text.Length)
            {
                isItRunning = false;
                break;
            }
            yield return new WaitForSeconds(0.03f);
        }

    }

    IEnumerator eliminarTrigger()
    {
        int i = 0;
        while (i < 10)
        {

            yield return new WaitForSeconds(1f);
            i++;
        }

        Destroy(GameObject.Find("DialogTrigger"));
        mainContainer.SetActive(false);

    }
}
