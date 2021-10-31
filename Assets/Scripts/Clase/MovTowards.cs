using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTowards : MonoBehaviour
{
    [SerializeField]
    GameObject ObjDestino;

    [SerializeField]
    float speed = 10;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        Vector3 origen = transform.position;
        Vector3 destino = ObjDestino.transform.position;
        
        transform.LookAt(destino);

        destino.x -= 10.0f;
        //destino.z -= 10.0f;
        

        transform.position =  Vector3.MoveTowards(origen, destino, speed * Time.deltaTime);

        //transform.position = Vector3.Lerp(origen, destino, speed * Time.deltaTime);

        //Vector3 currentVelocity = new Vector3(0f, 0f, 0f);
        //transform.position = Vector3.SmoothDamp(origen, destino,ref currentVelocity, speed * Time.deltaTime);

        float distancia = Vector3.Distance(origen, destino);
        Debug.Log(distancia);

    }
}
