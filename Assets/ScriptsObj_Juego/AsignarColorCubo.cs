using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarColorCubo : MonoBehaviour
{
    [SerializeField]
    CambioColorCubo ScriptCambioColor;

    Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.color = ScriptCambioColor.color;
    }
}
