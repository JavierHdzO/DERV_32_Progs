using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impactoBala : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject effectObject;

    ParticleSystem effect;
   
    void Start()
    {

        effect = effectObject.GetComponent<ParticleSystem>();
        effect.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }


    private void OnParticleCollision(GameObject other)
    {
        effect.Play();
    }

}
