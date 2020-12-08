using UnityEngine;
using System.Collections;
using System;

public class GoHomeAndRestTillRested : State<Miner>
{
    public static GoHomeAndRestTillRested instatance = new GoHomeAndRestTillRested();

    private GoHomeAndRestTillRested()
    {

    }
    public override GameObject target
    {
        get
        {
            return Directory.instance.home;
        }
    }
    public override void Enter(Miner entity)
    {
        MassageDispacther.instance.DispatchMassage(TimeSpan.Zero,entity,Elsa.instance, (int)MssageType.HeyHoneyImHome);
    }

    public override void Execute(Miner entity)
    {
        if (UnityEngine.Random.Range(0f, 1f) < .001f)
        {
            entity.stateMachine.TravelTo(EnterMineAndDigForNugget.instance);
        }
    }

    public override void Exit(Miner entity)
    {

    }

    public override bool handelMassage(Miner entity, Telegram tele)
    {
        if(tele.msg == (int)MssageType.StewReady)
        {
            entity.stateMachine.TravelTo(MinerEat.instance);
            return true;
        }
        return false;
    }
}
