using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    void Update()
    {
        EventSystem.test(); // adding subcriber and publisher messages
        EventSystem.Subs(); // Both Subscribers
    }
}
