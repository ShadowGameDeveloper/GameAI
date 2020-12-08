using UnityEngine;
using System.Collections;

public class EnterMineAndDigForNugget : State<Miner>
{
    public static EnterMineAndDigForNugget instance = new EnterMineAndDigForNugget();

    private EnterMineAndDigForNugget()
    {

    }

    public override GameObject target
    {
        get
        {
            return Directory.instance.mine;
        }
    }

    public override void Enter(Miner entity)
    {
       
    }

    public override void Execute(Miner entity)
    {
        entity.goldPerson++;
        entity.fatigue++;
        if (entity.PocketFull())
        {
            entity.stateMachine.TravelTo(VisitBankAndStoreGold.instance);
        }

        

    }

    public override void Exit(Miner entity)
    {

    }

    public override bool handelMassage(Miner entity, Telegram tele)
    {
        return false;
    }
}
