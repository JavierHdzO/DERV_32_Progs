using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardCamera : MonoBehaviour
{
    // Start is called before the first frame update

   
    public Transform cam;

    private void Awake()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
