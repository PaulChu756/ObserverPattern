using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class TranTask : MonoBehaviour
{
    public void Start()
    {
        EventSystem.Subscriber("Message", Doit);
        EventSystem.Subscriber("Keys", DoitNow);
    }

    public void Doit()
    {
        Debug.Log("Do it!!! :D");
    }
    public void DoitNow()
    {
        Debug.Log("Cookies and Pandas");
    }
}