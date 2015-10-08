using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public static class EventSystem
{
    static Dictionary<string, callBack> eventTable = new Dictionary<string, callBack>(); // Difference of Class of Delegate and delegate, callBack = delegate

    public static void Publisher(string message) // Publisher publishes a message, and the subscriber will subscriber to that message while I will exe the function.
    {
       if(eventTable.ContainsKey(message))
        {
            eventTable[message]();
        }
    }

    public static void Subscriber(string key, callBack function)
    {
        eventTable.Add(key, function);
    }

    [ContextMenu("Subs")]
    public static void Subs()
    {
        Subscriber("Message", InterestedSubs); // exe the function
    }

    public static void InterestedSubs()
    {
        Debug.Log("It works!");
    }

    public static void RemoveSubscriber(string message, callBack function) // if two subscribers are on one message, multicast them together.
    {
        if(eventTable.TryGetValue(message, out function))
        {
            eventTable[message] += function;
        }
    }

    public static void test()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Publisher("Message");
        }
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
