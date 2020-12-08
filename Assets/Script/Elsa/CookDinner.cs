using UnityEngine;
using System.Collections;
using System;

public class CookDinner : State<Elsa>
{
    public static CookDinner instance = new CookDinner();

    public CookDinner()
    {

    }
    public override GameObject target
    {
        get
        {
            return Directory.instance.kitchen;
        }
    }

    public override void Enter(Elsa entity)
    {

    }

    public override void Execute(Elsa entity)
    {
        if (UnityEngine.Random.Range(0f, 1f) < .01f)
        {
            MassageDispacther.instance.DispatchMassage(TimeSpan.Zero, entity, Miner.instance,(int)MssageType.StewReady);
            entity.stateMachine.TravelTo(ElsaEat.instance);
        }
    }

    public override void Exit(Elsa entity)
    {
        entity.lastDinner = DateTime.Now;
    }

    public override bool handelMassage(Elsa entity, Telegram tele)
    {
        return false;
    }
    
}
