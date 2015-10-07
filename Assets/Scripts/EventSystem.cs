using UnityEngine;
using System.Collections;
using System.Collections.Generic;

static public class EventSystem
{
    static Dictionary<string, callBack> _event = new Dictionary<string, callBack>();
    static List<object> subscribers = new List<object>();

    public static void publisher(string message)
    {
        Debug.Log("Event: " + message);
        callBack del;
        foreach(object o in _event)
        {
            _event.TryGetValue(message, out del);
        }
    }

    public static bool subscriber(string message, callBack func)
    {
        Subscriber subs = new Subscriber(message, func);
        object obj = subs as object;
        subscribers.Add(obj);

        return true;
    }


    private class Subscriber
    {
        private string m_message;
        private callBack callback;

        public Subscriber(string message, callBack cb)
        {
            m_message = message;
            callback = cb;
        }

        public string Message { get { return m_message.ToLower(); } }
        public callBack Method { get{ return callback; } }

    }

}