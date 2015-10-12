using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnManager : MonoBehaviour
{
    public int turnNumber;
    public List<GameObject> players;
    public GameObject currentTurn;

    public void NextTurn()
    {
        //currentTurn.GetComponent<GameStates>().EndTurn(); // Begin in Idle state
        turnNumber++;
        if (turnNumber >= players.Count) // If the turnNumber is greater than Player
        {
            turnNumber = 0;
        }
        currentTurn = players[turnNumber]; // It is the current player's turn in the list.

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("EndTurn");
        }
    }

    public void Attack()
    {
        //currentTurn.GetComponent<GameStates>().Attack();
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Attack");
        }
    }

    void Awake()
    {
        currentTurn = players[0];
    }

    void Update()
    {
        NextTurn();
        Attack();
    }
}
