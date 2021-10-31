using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZombieSeguimiento : MonoBehaviour
{

    [SerializeField]
    public Transform TargetLookAt;

    [SerializeField]
    GameObject FollowPlayer;

    [SerializeField]
    float speed = 2;

    public static bool BorrarMensaje = false;

    public Animation animation;
    bool stateStay = false;

    private void Awake()
    {
        FollowPlayer = GameObject.Find("Personaje");
        TargetLookAt = FollowPlayer.transform;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
        
    }

    // Update is called once per frame
    public void Update()
    {

        transform.LookAt(TargetLookAt);

        ColisionPersonaje();

        if (!stateStay)
        {
            animation.Stop("Walk");
            animation.Stop("Attack1");
            animation.Play("Idle");
        }

    }

    private void OnTriggerStay(Collider other)
    {
        
        if(other.tag == "Player")
        {

            if (animation.IsPlaying("Idle") || animation.IsPlaying("Attack1"))
            {
                animation.Stop("Idle");
    
                animation.PlayQueued("Walk");
                animation.PlayQueued("Idle");
            }
            

            Vector3 origen = transform.position;
            Vector3 destino = FollowPlayer.transform.position;

            transform.LookAt(destino);


            transform.position = Vector3.MoveTowards(origen, destino, speed * Time.deltaTime);

            float distancia = Vector3.Distance(origen, destino);

            stateStay = true;
        }     

    }

    private void OnTriggerExit(Collider other)
    {
        //animation.Play("ldle");


        if (animation.IsPlaying("Walk") || animation.IsPlaying("Attack1"))
        {
            animation.Stop("Walk");
            animation.Stop("Attack1");
            animation.Play("Idle");
        }

        stateStay = false;
    }

    public void ColisionPersonaje()
    {
        
        RaycastHit hit;
        
        if(Physics.Raycast(transform.position, transform.forward, out hit, 4, LayerMask.GetMask("Interactable"))){

            if(hit.transform.tag == "Player")
            {

                SistemaMarcador SM = hit.transform.GetComponent<SistemaMarcador>();

                SM.Mensaje.text = "A zombie is near";

                BorrarMensaje = false;

            }
            
        }
        else
        {
            BorrarMensaje = true;

        }


    }


}
