using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public static class EventSystem
{
    static Dictionary<string, callBack> eventTable = new Dictionary<string, callBack>(); // Difference of Class of Delegate and delegate, callBack = delegate

    public static void Publisher(string message) // Publisher publishes a message, and the subscriber will subscriber to that message while I will exe the function.
    {
       if(eventTable.ContainsKey(message)) // Tested and good
        {
            eventTable[message]();
            Debug.Log("Check if message is in the Dict, if so, exe it");
        }
    }

    public static void Subscriber(string message, callBack function) // Tested and good
    {
        CombineSubs(message, function);
    }

    public static void CombineSubs(string message, callBack function)
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


    public static void Subs()
    {
        Subscriber("Message", InterestedSubs); // exe the function
    }

    public static void s_Subs()
    {
        Subscriber("Keys", Keys);
    }
    public static void InterestedSubs()
    {
        Debug.Log("It works!");
    }
    public static void Keys()
    {
        Debug.Log("Shaking Keys");
    }

    public static void test() // Tested and good
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Publisher("Message");
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            Publisher("Keys");
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
