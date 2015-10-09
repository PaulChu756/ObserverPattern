using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public static class EventSystem<T>
{
    static Dictionary<T, callBack> eventTable = new Dictionary<T, callBack>(); // Difference of Class of Delegate and delegate, callBack = delegate
    public static void Publisher(T message) // Publisher publishes a message, and the subscriber will subscriber to that message while I will exe the function.
    {
       if(eventTable.ContainsKey(message))
        {
            eventTable[message]();
            Debug.Log("Check if message is in the Dict, if so, exe it");
        }
    }


    public static void Subscriber(T message, callBack function)
    {
        CombineSubs(message, function);
    }


    public static void CombineSubs(T message, callBack function)
    {
        if (eventTable.ContainsKey(message))
        {
            eventTable[message] += function; // eventTAble[message] callback delegate of that key
            Debug.Log("If the Subscribers to the same message, add them together");
        }
        else eventTable.Add(message, function);
        Debug.Log("Subscriber has been added");

        // I want to check if subscribers are subscribe to the same message
        // if they're on the same message, add them together.
    }
}

/*
Ok, Observer Patten. Like the fsm. Yup.
So I know, there are 3 important things, Publisher, Subscriber, Messager.
The Publisher will publish a message out whenever.
the message is just a string.
and the subscriber will subscribe to the message when the Publisher sends it out, it doesn't care "What" is in it, but by when, most likely when it's send out 
by the string and use a delegate to exe that function.

make a dictionary like this
Dictionary PaulsEventTable<string, Delegate>
|key        |value
alpha       null
bravo       null
charlie     null

    PaulsEventTable["alpha"] = what do you do? access it
*/


//static Dictionary<string, callBack> eventTable = new Dictionary<string, callBack>();

//public delegate void EventHandler();

//public static void addElement(string key, callBack T)
//{
//    eventTable.Add(key, null);
//}

//public static void Setup()
//{
//    addElement("Alpha", function);
//    addElement("Bravo", function);
//    addElement("Charlie", function);
//    addElement("Delta", function);
//    addElement("Foxtrot", function);
//}

//public static void function()
//{
//    Debug.Log("Function");
//}
