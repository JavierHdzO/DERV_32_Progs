using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMouse : MonoBehaviour
{
    [SerializeField]
    float speedX  = 20;

    [SerializeField]
    float speedY = 10;

    float ejeRotacionObj;
    float ejeRotacionCam;

    Rigidbody rb;

    [SerializeField]
    GameObject camara; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {    
        
    }

    private void FixedUpdate()
    {
        ejeRotacionObj = Input.GetAxis("Mouse X");
        ejeRotacionCam += Input.GetAxis("Mouse Y")*speedX;


        this.transform.Rotate(0, ejeRotacionObj * speedY, 0);

        ejeRotacionCam = Mathf.Clamp(ejeRotacionCam, -25, 25);
        camara.transform.localEulerAngles = new Vector3(-ejeRotacionCam, 0f, 0f);

        



    }
}
