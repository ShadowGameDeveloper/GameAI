using UnityEngine;
using System.Collections;

public class MinerEat : State<Miner>
{
    public static MinerEat instance = new MinerEat();

    public MinerEat()
    {

    }

    public override GameObject target
    {
        get
        {
            return Directory.instance.kitchen;
        }
    }

    public override void Enter(Miner entity)
    {

    }

    public override void Execute(Miner entity)
    {
        if(UnityEngine.Random.Range(0f,1f) < 0.01f)
        {
            entity.stateMachine.TravelTo(GoHomeAndRestTillRested.instatance);
        }
    }

    public override void Exit(Miner entity)
    {

    }

    public override bool handelMassage(Miner enity, Telegram tele)
    {
        return false;
    }

}
