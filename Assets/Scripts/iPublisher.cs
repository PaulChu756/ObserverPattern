using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public interface IPublisher<T>
{
    event EventHandler<Message_PC<T>> dataPublisher; // Publish a message of t name of dataPublisher.
    void publishData(T data); // publishData the message.
}