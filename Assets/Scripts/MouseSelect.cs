using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseSelect : MonoBehaviour // IT WORKS!
{
    public TurnManager turnManager;
    public Button attackButton;
    //public Color white;
    /*
        -----Thoughts-----
        So I use the mouse position to "Select targets"
        For the player to select which target they would like to attack.
        Once the player has choose their target, they pressed the attack button
        The attack Button will decrease their target's health according to the damage.
        Each player has one "Action" so therefore, they can only attack one time.
        Then they end their turn and this method repeats.
    */

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.gameObject.GetComponent<Unit>())
                {
                    //hit.transform.gameObject.GetComponent<Renderer>().material.color = Color.black;
                    Debug.Log("Selected Unit");
                }

                if (attackButton)
                {
                    turnManager.currentTurn.GetComponent<GameStates>().state.currentState = GameStates.gameState.ATTACK;
                    turnManager.currentTurn.GetComponent<Unit>().attack(hit.transform.gameObject);
                }
                // Once you select your target, you now press the attack button
                // to deal some type of damage or reduce their target's health by some amount.


                // Doesn't call right here
                //if (turnManager.currentTurn.GetComponent<GameStates>().state.currentState == GameStates.gameState.ATTACK)
                //{
                //    Debug.Log("Attacking Selected Target");

                //    turnManager.currentTurn.GetComponent<Unit>().attack(hit.transform.gameObject);
                //    turnManager.NextTurn();

                //    Debug.Log("Next Turn for someone else to attack");
                //}
            }
        } 
    }
}