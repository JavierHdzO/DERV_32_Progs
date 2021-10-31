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

        Gizmos.color = new Color32(75, 175, 197, 60);
        Gizmos.DrawWireSphere(transform.localPosition, 30f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color32(23, 255, 197, 60);
        Gizmos.DrawWireCube(transform.position, transform.localScale);
        Gizmos.DrawWireCube(transform.position, transform.localScale);
        if (this.tag.Equals("Personaje"))
        {
            

            Gizmos.DrawIcon(transform.position, "chat", true);

        }
    }
}
