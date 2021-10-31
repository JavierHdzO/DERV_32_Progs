using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopMoveTowards : MonoBehaviour
{
    bool isTheEnd;
    // Start is called before the first frame update
    void Start()
    {

        isTheEnd = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name.Equals("Mario"))
        {
            isTheEnd = true;

        }
    }

    public bool getIfIsTheEnd()
    {
        return isTheEnd;
    }
}
