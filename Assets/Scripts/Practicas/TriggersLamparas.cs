using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersLamparas : MonoBehaviour
{

    //Light luz;
    Light[] Luces;

    // Start is called before the first frame update
    void Start()
    {


        Luces = (Light[])GameObject.FindObjectsOfType(typeof(Light));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        string etiqueta = other.gameObject.tag;
        string nombre;

        if (etiqueta.Equals("Lampara"))
        {
            nombre = other.gameObject.name;

            if (nombre.Equals("Interruptor0"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz0"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor1"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz1"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor2"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz2"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor3"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz3"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor4"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz4"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor5"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz5"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor6"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz6"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor7"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz7"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor8"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz8"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor9-10"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz9"))
                    {
                        Luces[i].intensity = 3;
                    }
                    else if (Luces[i].name.Equals("Luz10"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor11-12"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz11"))
                    {
                        Luces[i].intensity = 3;
                    }
                    else if (Luces[i].name.Equals("Luz12"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor13"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz13"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor14"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz14"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor15"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz15"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor16"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz16"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor17"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz17"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor18"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz18"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor19"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz19"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor20"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz20"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor21"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz21"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor22"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz22"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor23"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz23"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor24"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz24"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor25"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz25"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor26"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz26"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor27"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz27"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor28"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz28"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor29"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz29"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor30"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz30"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor31"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz31"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor32"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz32"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor33"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz33"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor34"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz34"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor35"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz35"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor36"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz36"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor37"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz37"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor38"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz38"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor39"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz39"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor40"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz40"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor41"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz41"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor42"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz42"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor43"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz43"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor44"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz44"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor45"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz45"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor46"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz46"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor47"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz47"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
            else if (nombre.Equals("Interruptor48"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz48"))
                    {
                        Luces[i].intensity = 3;
                    }

                }
            }
        }

    }

    private void OnTriggerStay(Collider other)
    {



    }

    private void OnTriggerExit(Collider other)
    {

        string etiqueta = other.gameObject.tag;
        string nombre;

        if (etiqueta.Equals("Lampara"))
        {
            nombre = other.gameObject.name;

            if (nombre.Equals("Interruptor"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            
            else if(nombre.Equals("Interruptor1"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz1"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor2"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz2"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor3"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz3"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor4"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz4"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor5"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz5"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor6"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz6"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor7"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz7"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor8"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz8"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor9-10"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz9"))
                    {
                        Luces[i].intensity = 0;
                    }
                    else if (Luces[i].name.Equals("Luz10"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor11-12"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz11"))
                    {
                        Luces[i].intensity = 0;
                    }
                    else if (Luces[i].name.Equals("Luz12"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor13"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz13"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor14"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz14"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor15"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz15"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor16"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz16"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor17"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz17"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor18"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz18"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor19"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz19"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor20"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz20"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor21"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz21"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor22"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz22"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor23"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz23"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor24"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz24"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor25"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz25"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor26"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz26"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor27"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz27"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor28"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz28"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor29"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz29"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor30"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz30"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor31"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz31"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor32"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz32"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor33"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz33"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor34"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz34"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor35"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz35"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor36"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz36"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor37"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz37"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor38"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz38"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor39"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz39"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor40"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz40"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor41"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz41"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor42"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz42"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor43"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz43"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor44"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz44"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor45"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz45"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor46"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz46"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor47"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz47"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
            else if (nombre.Equals("Interruptor48"))
            {
                for (int i = 0; i < Luces.Length; i++)
                {
                    if (Luces[i].name.Equals("Luz48"))
                    {
                        Luces[i].intensity = 0;
                    }

                }
            }
        }

    }

}
