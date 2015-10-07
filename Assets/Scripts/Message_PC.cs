using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Message_PC<T> : EventArgs
{
    public T message
    {
        get; // Get by interested sub
        private set; // publish by publisher
    }
    public Message_PC(T messageArgu) // Can use Message_PC as a instance of the class due too of T
    {
        messageArgu = message;
    }


}
