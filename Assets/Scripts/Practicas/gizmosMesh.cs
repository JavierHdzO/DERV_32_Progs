using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gizmosMesh : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private Mesh model;
    

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color32(145, 125, 45,78);
        Gizmos.DrawWireMesh(model, transform.position, Quaternion.identity, Vector3.one*170);
    }
}
