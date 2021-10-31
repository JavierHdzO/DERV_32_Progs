using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartConversationWMario : MonoBehaviour
{
    [SerializeField]
    CrearDialogoProject dialogo;
    public GameObject mainContainer;
    public GameObject missionContainer;
    public GameObject mainCharacter;
    public GameObject Mario;
    public Image imageCharacter;
    public TextMeshProUGUI textMesh;
    public TextMeshProUGUI currentMission;
    int indice = 0;
    bool isOnTrigger;
    bool isItRunning;
    bool isTheLastMessage;
    Vector3 target;
    stopMoveTowards scriptStopMoveTowards;


    private void Awake()
    {
        mainContainer = GameObject.Find("ContenedorConversacion");
        imageCharacter = mainContainer.GetComponentInChildren<Image>();
        textMesh = mainContainer.GetComponentInChildren<TextMeshProUGUI>();
        missionContainer = GameObject.Find("ContenedorMision");
        currentMission = missionContainer.GetComponentInChildren<TextMeshProUGUI>();
    }
    void Start()
    {
        mainContainer.SetActive(false);
        isOnTrigger = false;
        isTheLastMessage = false;
        mainCharacter = GameObject.Find("CuerpoPersonaje");
        Mario = GameObject.Find("Mario");
        scriptStopMoveTowards = FindObjectOfType<stopMoveTowards>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("CuerpoPersonaje")) //Mostrar el dialogo en el que se quedo
        {
            if (indice < dialogo.conversacionMarioLength() - 1) //Solamente active el contenedor de dialogos mientres alla dialogos por mostrar.
            {
                mainContainer.SetActive(true);
            }
            textMesh.text = dialogo.conversacionMario[indice].nombrePersonaje + ": " + dialogo.conversacionMario[indice].Message;
            imageCharacter.sprite = dialogo.conversacionMario[indice].CharacterImage;
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
        if (isOnTrigger)
        {
            Mario.transform.LookAt(mainCharacter.transform.position);
        }
        if (isOnTrigger && Input.GetKeyDown(KeyCode.E) && indice < dialogo.conversacionMarioLength() - 1 && !isItRunning)
        {
            indice++;
            textMesh.text = dialogo.conversacionMario[indice].nombrePersonaje + ": " + dialogo.conversacionMario[indice].Message;
            imageCharacter.sprite = dialogo.conversacionMario[indice].CharacterImage;

            textMesh.maxVisibleCharacters = 0;
            StopAllCoroutines();
            StartCoroutine("mostrarTexto");


        }
        if (isOnTrigger && Input.GetKeyDown(KeyCode.Q) && indice > 0 && !isItRunning)
        {
            indice--;
            textMesh.text = dialogo.conversacionMario[indice].nombrePersonaje + ": " + dialogo.conversacionMario[indice].Message;
            imageCharacter.sprite = dialogo.conversacionMario[indice].CharacterImage;

            textMesh.maxVisibleCharacters = 0;
            StopAllCoroutines();
            StartCoroutine("mostrarTexto");
        }



        if (scriptStopMoveTowards.getIfIsTheEnd())
        {
            Mario.transform.position = Vector3.MoveTowards(Mario.transform.position, Mario.transform.position, 20f * Time.deltaTime);
            PlayerPrefs.SetString("result", "You Won !!!");
            SceneManager.LoadScene(2);
        }
        else
        {

            if (indice == dialogo.conversacionMarioLength() - 1)
            {
                //isTheLastMessage = true;
                missionContainer.SetActive(true);

                target = new Vector3(mainCharacter.transform.position.x - 3f, mainCharacter.transform.position.y, mainCharacter.transform.position.z - 3f);
                Mario.transform.position = Vector3.MoveTowards(Mario.transform.position, target, 20f * Time.deltaTime);
                Mario.transform.LookAt(target);

                StartCoroutine("ocultarMensaje");
            }
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

    IEnumerator ocultarMensaje()
    {
        int i = 0;
        while (i < 10)
        {

            yield return new WaitForSeconds(1f);
            i++;
        }

        mainContainer.SetActive(false);

    }

}
