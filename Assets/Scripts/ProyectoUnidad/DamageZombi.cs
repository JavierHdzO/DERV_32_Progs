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
    int zombies = 0;
    float distance;
    Transform player;


    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.Find("Personaje").transform;
    }

    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        healthBar.SetMaxHealth();

    }

    // Update is called once per frame
    void Update()
    {
        zombies = PlayerPrefs.GetInt("zombies");
        distance = Vector3.Distance(player.position, transform.position);
        if (distance > 70)
        {
            DecrementaZombi();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Municion"))
        {

            vida -= (int)Random.Range(20f, 50f);
            healthBar.SetHealth(vida);
            if (vida <= 0)

            {
                score = PlayerPrefs.GetInt("Score");
                score += 100;
                PlayerPrefs.SetInt("Score", score);
                DecrementaZombi();
                Destroy(gameObject);

            }

        }
    }

    private void DecrementaZombi()
    {
        zombies = PlayerPrefs.GetInt("zombies");
        zombies--;
        PlayerPrefs.SetInt("zombies", zombies);
    }

}



