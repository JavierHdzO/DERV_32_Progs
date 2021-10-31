using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster_Code : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origen = transform.position;
        Vector3 direccion = new Vector3(0, -1, 0);
        RaycastHit hit; //Almacena informacion de la colision. Consultar: https://docs.unity3d.com/ScriptReference/RaycastHit.html
        float distancia = 2f;  //Distancia máxima del rayo. Si no se establece es Infinito
        int layerMask; //Capa con la que se de sea validar la colisión (No utilizado de momento)
                                              //Por defecto revisa todas las capas 
        QueryTriggerInteraction queryTrigger = QueryTriggerInteraction.Collide; 
                                              //determina si ´la colisión considerará a los objetos que sean triggers

        float duracionRayo = 1;

        if (Physics.Raycast(origen, direccion, out hit, distancia))
        {
            //hit.   <- para extrar informacion del objeto con el que se colisiono 
            Debug.DrawRay(origen, direccion * hit.distance, Color.yellow, duracionRayo);

            /*
            string nombre= hit.collider.gameObject.name;
            GameObject temp =  GameObject.Find(nombre);
            Destroy(temp);
            */

        }
        else {
            Debug.DrawRay(origen, direccion * distancia, Color.red, duracionRayo);
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        //origen, dirección
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
    }
}
