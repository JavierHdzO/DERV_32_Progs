using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaBala : MonoBehaviour
{
    [SerializeField]
    float speedBullet = 10;

    int cont = 0;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speedBullet, ForceMode.Impulse);
    }

    

}
