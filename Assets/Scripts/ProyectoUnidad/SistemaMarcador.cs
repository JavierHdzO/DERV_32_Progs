using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SistemaMarcador : MonoBehaviour
{
    
    int vida = 100;
    public int puntuaje = 0;

    [SerializeField]
    public TextMeshProUGUI NombreUsuario;

    [SerializeField]
    public TextMeshProUGUI TXTPuntuaje;

    [SerializeField]
    public TextMeshProUGUI TXTVida;

    [SerializeField]
    public TextMeshProUGUI Mensaje;

    public GameObject Mario;

    private Animation animationZom;
    private bool stayColl;
    int healths;
    // Start is called before the first frame update


    private void Awake()
    {
        Mario = GameObject.Find("Mario");
    }
    void Start()
    {
        Mario.SetActive(false);

        string usuario = PlayerPrefs.GetString("Player");
        NombreUsuario.text = usuario.ToString();

        stayColl = false;
        StartCoroutine("DownHealth");

        PlayerPrefs.SetString("result", "");

    }

    // Update is called once per frame
    void Update()
    {


        TXTPuntuaje.text = PlayerPrefs.GetInt("Score").ToString();
        TXTVida.text = vida.ToString();

        if (ZombieSeguimiento.BorrarMensaje.Equals(true))
        {
            Mensaje.text = "";
        }

        Marcadores();

    }

    public void Marcadores()
    {

        if (vida <= 0)
        {
            int score = int.Parse(TXTPuntuaje.text);
            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.SetString("result", "You are dead");
            SceneManager.LoadScene(2);

        }

    }

    private void OnCollisionEnter(Collision collision)
    {



        if (collision.gameObject.tag.Equals("Health"))
        {
            if (vida < 100)
            {
                int temp = (vida + 20) >= 100 ? (100-vida) : 20;
                vida += temp;
                healths = PlayerPrefs.GetInt("health");
                healths--;
                PlayerPrefs.SetInt("health", healths);
                Destroy(collision.gameObject);
            }

        }

    }


    private void OnCollisionExit(Collision collision)
    {
        GameObject temp = collision.gameObject;
        if (temp.tag.Equals("Zombie"))
        {
            if (temp != null)
            {
                //animationZom.Play("Run");
                animationZom.PlayQueued("Walk");
                animationZom.PlayQueued("Idle");
                stayColl = false;
            }
        }

    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Zombie"))
        {
            animationZom = collision.gameObject.GetComponent<Animation>();

            stayColl = true;

        }
    }


    IEnumerator DownHealth()
    {
        while (true)
        {
            if (vida > 0)
            {
                if (stayColl)
                {
                    if (animationZom)
                    {
                        animationZom.Play("Attack1");
                        animationZom["Attack1"].speed = 2;
                        vida -= Random.Range(20, 35);
                    }


                }
                else
                {
                    if (animationZom != null)
                    {
                        animationZom.Stop("Attack1");
                        animationZom.Play("Walk");
                    }
                }

            }
            else
            {
                vida = 0;
                break;
            }

            yield return new WaitForSeconds(1.5f);
        }
    }

}
