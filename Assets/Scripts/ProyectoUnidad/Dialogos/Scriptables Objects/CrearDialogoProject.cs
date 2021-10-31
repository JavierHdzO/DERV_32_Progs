using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Conversacion", menuName = "CrearConversacion", order = 1)]
public class CrearDialogoProject : ScriptableObject
{
    [Serializable]
    public struct Conversation
    {
        [TextArea(2, 5)]
        public string Message;
        public string nombrePersonaje;
        public Sprite CharacterImage;

    }

    public Conversation[] conversacionKarolina;
    public Conversation[] conversacionMario;

    public int conversacionKaroLength()
    {
        return conversacionKarolina.Length;
    }

    public int conversacionMarioLength()
    {
        return conversacionMario.Length;
    }

   
}
