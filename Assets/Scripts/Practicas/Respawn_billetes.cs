using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_billetes : MonoBehaviour
{
    // Start is called before the first frame update
    public int cantidad_Billetes = 5;
    public GameObject generatedObject;//objeto a generar (billetes)
    public GameObject referenceObject; //objeto que ayudara a ubicar el spawn de los billetes.
    public GameObject spawn; //zona spawn
    float positionXzoneSpawn, positionZzoneSpawn, scaleX, scaleZ;
    GameObject obj;


    void Start()
    {
        positionXzoneSpawn = spawn.transform.position.x;
        positionZzoneSpawn = spawn.transform.position.z;
        scaleX = spawn.transform.localScale.x;
        scaleZ = spawn.transform.localScale.z;
        //Debug.Log(positionXzoneSpawn+", "+ positionZzoneSpawn + ", "+ scaleX +", "+ scaleZ);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        //Debug.Log("este es el trigger " + spawn.name);
        //Debug.Log("Colision con " + other.gameObject.name);
        string etiqueta = other.gameObject.name;
        if (etiqueta.Equals("Persona"))//cambiar a nombre de tu personaje
        {
            for (int i = 0; i < cantidad_Billetes; i++)
            {
                referenceObject.transform.position =new Vector3(Random.Range(positionXzoneSpawn - (scaleX/2), positionXzoneSpawn + (scaleX / 2)) , 15
                    , Random.Range(positionZzoneSpawn - (scaleZ / 2), positionZzoneSpawn + (scaleZ / 2)));

                    Debug.Log(referenceObject.transform.position.x);
                    Debug.Log(referenceObject.transform.position.y);
                    Debug.Log(referenceObject.transform.position.z);
                //Debug.Log(referenceObject.transform.position);
                obj = Instantiate(generatedObject, referenceObject.transform.position, referenceObject.transform.rotation ) as GameObject;
                obj.name = "billete" + i;
            }
            //Debug.Log("Colision con " + etiqueta);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < cantidad_Billetes; i++)
        { 
            Destroy(obj = GameObject.Find("billete" + i));
        }
    }
}
