using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    [System.Serializable]
    public class Message
    {
        public int actorID;
        public string message;
    }

    [System.Serializable]
    public class Actor
    {
        public string name;
        public Sprite sprite;
    }

}
