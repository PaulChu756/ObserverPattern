using UnityEngine;
using System.Collections;

public class MouseSelect : MonoBehaviour // IT WORKS!
{
    TurnManager turnManager;
    public Color white;
    /*
        -----Thoughts-----
        So I use the mouse position to "Select targets"
        For the player to select which turn they would like to attack.
        Once the player has choose their target, they pressed the attack button
        The attack Button will decrease their target's health according to the damage.
        Each player has one "Action" so therefore, they can only attack one time.
        Then they end their turn and this method repeats.
    */

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.gameObject.GetComponent<Unit>())
                {
                    hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.black; // Select
                    Debug.Log("Unit selected");
                }
                else
                {
                    hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.white;
                }
            }
        } 
    }
}