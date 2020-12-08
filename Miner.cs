using UnityEngine;
using System.Collections;

public class Miner : BaseGameEntity
{
    State currentState;

    int goldPerson;
    int goldInBank;
    int thrist;
    int fatigue;

    public void ChangeState(State newState)
    {
        if(currentState != null)
        {
            currentState.Exit(this);
        }
        currentState = newState;
        currentState.Enter(this);
    }

    protected void FixedUpdate()
    {
        thrist++;
        if(currentState != null)
        {
            currentState.Execute(this);
        }
    }
}
