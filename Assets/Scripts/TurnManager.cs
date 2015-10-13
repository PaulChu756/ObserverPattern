using UnityEngine;
using System.Collections.Generic;

public class TurnManager : MonoBehaviour
{
    public int turnNumber;
    public List<GameObject> players;
    public GameObject currentTurn;

    /*
        Turn Manager, it turnNumber starts off at 0 and will increment by 1 as it's the next player's turn
        So the turnNumber will only increment by each next turn
        Example: 
            TurnNumber 0 = Player 1
            TurnNumber 1 = Player 2
            TurnNumber 2 = Player 3
            TurnNumber 3 = Enemy  1
            TurnNumber 4 = Enemy  2
            TurnNumber 5 = Enemy  3
    */
    void Start()
    {
        Debug.Log("Start Hit");
        currentTurn = players[0];
    }
    public void NextTurn() // Works!?
    {
        Debug.Log("NextTurn Hit");
        currentTurn.GetComponent<GameStates>().EndTurn(); // This Mo - Fucker

        turnNumber++; // increment the turn number by 1
        if (turnNumber >= players.Count) // If the turnNumber is greater than Player
        {
            turnNumber = 0; // Resetting the turn number
        }
        currentTurn = players[turnNumber]; // It is the current player's turn in the list.
    }

    public void Attack()
    {
        //currentTurn.GetComponent<Unit>().Attack());
    }

   
}
