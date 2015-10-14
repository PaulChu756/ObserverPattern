using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameStates : MonoBehaviour
{
    public enum gameState{ INIT, IDLE, ATTACK, ENDTURN} // States

    public FSM_PC<gameState> state = new FSM_PC<gameState>(); // List of states

    TurnManager turnManager;

    void Awake()
    {
        state.addState(gameState.INIT); // Adding all the states
        state.addState(gameState.IDLE);
        state.addState(gameState.ATTACK);
        state.addState(gameState.ENDTURN);

        // Transitions here
        state.addTransition(gameState.INIT, gameState.IDLE, null); // adding all the transition of states to the next state
        state.addTransition(gameState.IDLE, gameState.ATTACK, null);
        state.addTransition(gameState.ATTACK, gameState.ENDTURN, null);
        state.addTransition(gameState.ENDTURN, gameState.IDLE, null);

        state.currentState = gameState.INIT; // set the current start off state is INIT
        Idle();
    }

    public void Idle()
    {
        state.changingState(gameState.IDLE); // Check all the transition of each state
    }

    public void Attack()
    {
        Debug.Log("Attacking State");
        state.changingState(gameState.ATTACK);

    }

    public void EndTurn()
    {
        state.changingState(gameState.ENDTURN);
        Idle();
    }
}
