using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Testing_PC : MonoBehaviour
{ 
    /*
        I used Tran's test to see if my FSM works, I did change names here and there.
        But I'm not going to claim this as Paul Chu.
    */

    public enum state
    {
        cooking, eating, sleeping,
    }

    FSM_PC<state> fsm = new FSM_PC<state>();

    void Start()
    {
        state[] states = (state[])Enum.GetValues(typeof(state));
        foreach (state s in states)
        {
            fsm.addState(s);
            print("Added this state: " + s.ToString());
        }
        fsm.currentState = state.cooking;
        Debug.Log("Current State: " + fsm.currentState.ToString());
        fsm.addTransition(state.cooking, state.eating, helpTran);
        fsm.addTransition(state.eating, state.sleeping, GoHome);
    }

    //[ContextMenu("Make FSM")]
    void test()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { fsm.changingState(state.eating); }

        if (Input.GetKeyDown(KeyCode.D))
        { fsm.changingState(state.sleeping); }
    }
    void Update()
    {
        test();
    }

    delegate void del();
    del Del;
    Dictionary<string, callBack> transitionTable = new Dictionary<string, callBack>();
    public string transition = "cooking to eating";



    [ContextMenu("Test Add")]
    void TestAdd()
    {
        transitionTable.Add(transition, helpTran); // add 
    }

    [ContextMenu("Do it")]
    void DoIt()
    {
        transitionTable[transition](); // exe functions
    }



    public void GoHome()
    {
        Debug.Log("Teacher is going home");
    }


    public void helpTran()
    {
        Debug.Log("help tran");
    }
}

/*
    |key                          |value
    |morning->lunch               |helpTran()
    |lunch->evening               |helpEverybodyElse()
    |evening->exitt               |goHome()
    |                             |
*/
