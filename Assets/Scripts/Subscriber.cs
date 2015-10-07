using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Subscriber<T>
{
    public Dictionary<string, callBack> subs = new Dictionary<string, callBack>();

    public IPublisher<T> Publisher { get; private set; }
    public Subscriber(IPublisher<T> publisher)
    {
        Publisher = publisher;
    }

}



//void subcriber(string keyWord, callBack function) // Just like delegates, use keywords and callback function to exe delegates.
//{
//    subs.Add(keyWord, function);
//}