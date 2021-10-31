using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class DamageZombi : MonoBehaviour
{

    public  HealthBar healthBar;
    [SerializeField]
    public TextMeshProUGUI SCORE;
   
    int vida = 100;
    int score = 0;
    int zobmbies =0 ;


    // Start is called before the first frame update

    void Start()
    {
        score =  PlayerPrefs.GetInt("Score");
        healthBar.SetMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Municion"))
        {
           
            vida -= (int)Random.Range(20f, 50f);
            Debug.Log(vida.ToString());
            healthBar.SetHealth(vida);
            if (vida <= 0)

            {
                score = PlayerPrefs.GetInt("Score");
                score += 100;
                PlayerPrefs.SetInt("Score", score);
                zobmbies = PlayerPrefs.GetInt("Zombies");
                zobmbies -= 1;
                PlayerPrefs.SetInt("Zombies", zobmbies);

                Destroy(gameObject);
            }

            }
        }
    }

    

