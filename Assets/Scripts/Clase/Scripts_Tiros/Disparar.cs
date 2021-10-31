using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    [SerializeField]
    GameObject posSpawner;
    [SerializeField]
    GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject bull = Instantiate(bullet, posSpawner.transform.position,
                posSpawner.transform.rotation);

            Destroy(bull, 2);

        }
    }
}
