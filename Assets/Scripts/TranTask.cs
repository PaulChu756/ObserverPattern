using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class TranTask
{
    public static void Start()
    {
        EventSystem.Subscriber("Message", Doit);
    }

    public static void Doit()
    {
        Debug.Log("Do it!!! :D");
    }
}
