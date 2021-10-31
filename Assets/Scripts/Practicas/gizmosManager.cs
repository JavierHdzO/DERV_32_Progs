using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizmosManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        //Sebas
        Gizmos.color = new Color32(75, 175, 197, 60);
        Gizmos.DrawSphere(transform.localPosition, 30f);
        //Gizmos.(transform.localPosition, 30f);
    }

    private void OnDrawGizmosSelected()
    {
        if (this.tag.Equals("Personaje")) 
        {
            //Wero
            Gizmos.color = new Color32(23, 255, 197, 60);
            Gizmos.DrawCube(transform.position, transform.localScale);
            //Gizmos.DrawWireCube(transform.position, transform.localScale);


            //Chucho
            Gizmos.DrawIcon(transform.position, "chat", true);

        }
    }
}
