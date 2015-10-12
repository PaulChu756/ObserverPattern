using UnityEngine;
using System.Collections;

//public class Test : MonoBehaviour
//{
//void Update()
//{
//    EventSystem.test(); // adding subcriber and publisher messages
//    EventSystem.Subs(); // Both Subscribers
//}

//public static void Subs()
//{
//    EventSystem.Subscriber("Message", InterestedSubs); // exe the function
//}

//public static void s_Subs()
//{
//    EventSystem.Subscriber("Keys", Keys);
//}
//public static void InterestedSubs()
//{
//    Debug.Log("It works!");
//}
//public static void Keys()
//{
//    Debug.Log("Shaking Keys");
//}

//public static void test() // Tested and good
//{
//    if (Input.GetKeyDown(KeyCode.A))
//    {
//        EventSystem.Publisher("Message");
//    }
//    if (Input.GetKeyDown(KeyCode.D))
//    {
//        EventSystem.Publisher("Keys");
//    }
//}
//}


//    //public void Start()
//    //{
//    //    EventSystem.Subscriber("Message", Doit);
//    //    EventSystem.Subscriber("Keys", DoitNow); // The subscriber will subscribe to the message "Message" or "Keys" and exe the functions of Doit or DoitNow
//    //}

//    //public void Doit()
//    //{
//    //    Debug.Log("Do it!!! :D");
//    //}
//    //public void DoitNow()
//    //{
//    //    Debug.Log("Cookies and Pandas");
//    //}