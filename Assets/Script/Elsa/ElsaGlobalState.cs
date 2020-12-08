using UnityEngine;
using System.Collections;
using System;
public class ElsaGlobalState : State<Elsa>
{
    public static ElsaGlobalState instance = new ElsaGlobalState();

    private ElsaGlobalState()
    {

    }

    public override GameObject target
    {
        get
        {
            return null;
        }
    }

    public override void Enter(Elsa entity)
    {
        
    }

    public override void Execute(Elsa entity)
    {
        
    }

    public override void Exit(Elsa entity)
    {
        
    }

    public override bool handelMassage(Elsa entity, Telegram tele)
    {
        if(tele.msg == (int)MssageType.HeyHoneyImHome)
        {
            if(DateTime.Now - entity.lastDinner > TimeSpan.FromSeconds(20))
            {

            }
            entity.stateMachine.TravelTo(CookDinner.instance);
            return true;
        }
        return false;
    }
}
