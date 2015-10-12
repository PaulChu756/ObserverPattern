using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameStates : MonoBehaviour
{
    public enum gameState{ INIT, IDLE, ATTACK, ENDTURN} // States

    FSM_PC<gameState> state = new FSM_PC<gameState>(); // List of states
    callBack initToIdle;
    callBack idleToAttack;
    callBack attacktoEndTurn;
    callBack endTurnToIdle;

    void Awake()
    {
        state.addState(gameState.INIT); // Adding all the states
        state.addState(gameState.IDLE);
        state.addState(gameState.ATTACK);
        state.addState(gameState.ENDTURN);

        // Transitions here
        state.addTransition(gameState.INIT, gameState.IDLE, initToIdle); // adding all the transition of states to the next state
        state.addTransition(gameState.IDLE, gameState.ATTACK, idleToAttack);
        state.addTransition(gameState.ATTACK, gameState.ENDTURN, attacktoEndTurn);
        state.addTransition(gameState.ENDTURN, gameState.IDLE, endTurnToIdle);

        state.currentState = gameState.INIT; // set the current start off state is INIT
    }

    public void Idle()
    {
        state.changingState(gameState.IDLE);
        state.checkTransition(gameState.INIT, gameState.IDLE); // Check all the transition of each state
    }

    public void Attack()
    {
        state.changingState(gameState.ATTACK);
        state.checkTransition( gameState.IDLE, gameState.ATTACK);
    }

    public void EndTurn()
    {
        state.changingState(gameState.ENDTURN);
        state.checkTransition(gameState.ATTACK, gameState.ENDTURN);
        Idle();
    }
}
