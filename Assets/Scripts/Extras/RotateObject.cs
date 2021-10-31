using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody billete;
    public float angle = 0f;
    void Start()
    {
        billete = GetComponent<Rigidbody>();
        billete.constraints = RigidbodyConstraints.FreezePositionY;
        StartCoroutine("rotarObjeto");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator rotarObjeto() 
    {
        while (true) 
        {
            billete.transform.Rotate(0, 0, angle);
            angle = angle + 10f;
            if (angle == 181f)
            {
                angle = 0f;
            }
            yield return new WaitForSeconds(0.5f);
        }
        
    }
}
