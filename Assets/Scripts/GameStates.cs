using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameStates : MonoBehaviour
{
    public enum gameState{ INIT, IDLE, ATTACK, ENDTURN} // States

    FSM_PC<gameState> state = new FSM_PC<gameState>();

    void Awake()
    {
        state.addState(gameState.INIT);
        state.addState(gameState.IDLE);
        state.addState(gameState.ATTACK);
        state.addState(gameState.ENDTURN);

        state.addTransition(gameState.INIT, gameState.IDLE, null);
    }
    // Transitions here
}
