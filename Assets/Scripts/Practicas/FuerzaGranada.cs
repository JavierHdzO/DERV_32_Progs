using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaGranada : MonoBehaviour
{
    [SerializeField]
    float speedBullet = 10;

    [SerializeField]
    float tiempo = 8f;

    [SerializeField]
    GameObject effectoExplosion;
    private GameObject effect;
    private float momentoExplosion;
    private bool activoEffect = true;
    Rigidbody rb;
 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("sound");
        momentoExplosion = Time.time + tiempo ;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(transform.forward * speedBullet, ForceMode.Impulse);
        if (Time.time > momentoExplosion && activoEffect) 
            {
            //Sound 
                
                //Destruir la granada
                Destroy(gameObject, 0.5f);

                //Explocion
                effect = Instantiate(effectoExplosion, transform.position, transform.rotation);
                Destroy(effect, 1.5f);

                activoEffect = false;
                
            }

    }

    IEnumerator sound() 
    {
        for (int i = 0; i < 1; i++)
        {
            yield return new WaitForSeconds(3.72f);
        }
        GetComponent<AudioSource>().Play();

    }

}
