using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Publisher<T> : IPublisher<T>
{
    public event EventHandler<Message_PC<T>> dataPublisher;

    private void onDataPublisher(Message_PC<T> argument)
    {
        var handler = dataPublisher; // var is fucking magic.
        if(handler != null)
        {
            handler(this, argument);
        }
    }
    public void publishData(T data)
    {
        Message_PC<T> message = (Message_PC<T>)Activator.CreateInstance(typeof(Message_PC<T>), new object[] { data });

    }
}
