using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Mov_Personaje : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textoVida;

    [SerializeField]
    float speedForce = 20; 

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        textoVida.text = 1000.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {            
            rb.AddForce(transform.forward * speedForce, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward* -1f * speedForce, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right*-1 * speedForce, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speedForce, ForceMode.Acceleration);
        }

    }
}
