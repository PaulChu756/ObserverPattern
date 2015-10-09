using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class FSM_PC <T>
{
    public Dictionary<string, callBack> transactionTable = new Dictionary<string, callBack>(); // A dictionary of strings and a delegate named callBack.
    public List<T> gameState = new List<T>(); // Making a list to store information of T.
    private string keyName; // the keyName is for the Strings in the Dictionary
    public T currentState; // a public Template currentState
    callBack del; 

    public void addState(T state) // add States, let the user add the states and store them.
    {
        if (gameState.Contains(state)) // Checks if the state exist in the list
        {
            Debug.Log("Can't add the same state to the list"); // If the state exist, cout message
        }
        else
        {
            gameState.Add(state); // Add the state in the list
            Debug.Log("This " + state + " has been added to this list");
        }   
    }
    /*
        For What I understand so far. Delegates are used by a 'callBack' to exe whatever functions we pass into it. 
        First, we add the states, having both currentStates and nextStates as T's(templates). 
        adding the Transitions which have both states and the delegate that exe's all the functions that goes between those states.

    */ 
    public void addTransition(T currentState, T nextState, callBack del) // letting the user add transitions
    {
        if (gameState.Contains(currentState) && gameState.Contains(nextState)) // Checks if the current and nextState in the list
        {
            keyName = currentState.ToString() + "going to state: " + nextState.ToString(); // Putting the current and nextStates to strings because keyName is a string as well.
            transactionTable.Add(keyName, del); // adding the string and function into the dictonary.
            Debug.Log("Added transaction");
        }

        else
        {
            Debug.Log("Couldn't add transaction, try again please");
        }
    }

    public void changingState(T nextState) // Changing the states
    {
        checkTransition(currentState, nextState);
    }

    private void checkTransition(T currentState, T nextState) // Checking the transitions
    {
        keyName = currentState.ToString() + "going to state " + nextState.ToString();

        foreach (object o in transactionTable)
        {
            transactionTable.TryGetValue(keyName, out del);
            currentState = nextState;
            Debug.Log("Current state is: " + currentState.ToString());
        }
    }
}

/*
 finite-state machine 
 For precision flow control.
 Add States
 Have states going from one state to another
 As the states go to one state to another, use delegates to exe all the functions for that state.
 Let user add in delegates
 Change current states to gotostates
 check the change of states
*/

//void addDelegate(T t_delegate) // for transitions.
//{

//}

//void exeFunctions(callBack t_delegate)
//{
//    transactionTable[transaction](); // exe that function.
//    transactionTable.Add("chuiChu", t_delegate);
//}

//void chuiChu()
//{
//    Debug.Log("Thank you");
//}

//void cookies()
//{
//    Debug.Log("Thank you"); 
//}
