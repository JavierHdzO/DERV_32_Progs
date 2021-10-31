using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineGizmos : MonoBehaviour
{
    [Range(0f, 360f)]
    public float visionAngle = 90f;
    public float visionDistance = 2f;


    private void OnDrawGizmos()
    {
        if (visionAngle >= 0F)
        {
            float halfVision = visionAngle * .5f;
            Gizmos.DrawLine(transform.position,Vista(halfVision));
            Gizmos.DrawLine(transform.position, Vista(-halfVision));
        }
    }

    private Vector3 Vista(float angle) 
    {
        Vector2 temp =new  Vector3(
                Mathf.Cos(angle * Mathf.Deg2Rad) * visionDistance,
                Mathf.Sin(angle * Mathf.Deg2Rad) * visionDistance
            );
        transform.TransformDirection(temp);
        return temp;
    }
}
