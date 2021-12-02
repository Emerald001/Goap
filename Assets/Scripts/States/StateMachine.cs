using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces;

public class StateMachine
{
    private IState currentState;

    public void SwitchState(IState state)
    {
        if (state == currentState)
            return;

        currentState.OnExit();

        currentState = state;

        currentState.OnEnter();
    }

    public void OnUpdate()
    {
        currentState.OnUpdate();
    }
}
