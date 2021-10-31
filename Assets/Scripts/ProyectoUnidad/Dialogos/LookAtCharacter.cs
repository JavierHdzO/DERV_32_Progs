using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject arrow;
    GameObject character;
    Vector3 target;
    void Start()
    {
        arrow = GameObject.Find("Arrow");
        character = GameObject.Find("SurvivorMan");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        target = character.transform.position;
        arrow.transform.LookAt(target);
    }
}
