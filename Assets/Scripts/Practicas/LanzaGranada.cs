using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanzaGranada : MonoBehaviour
{
    [SerializeField]
    GameObject posSpawner;
    [SerializeField]
    GameObject granade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] granades = GameObject.FindGameObjectsWithTag("granade");    

            if (Input.GetKeyDown(KeyCode.G) && granades.Length == 0)
            {
                GameObject newGranade = Instantiate(granade, posSpawner.transform.position,
                    posSpawner.transform.rotation);

            }
    }


   
}
