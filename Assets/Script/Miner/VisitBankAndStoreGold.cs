using UnityEngine;
using System.Collections;

public class VisitBankAndStoreGold : State<Miner>
{

    public static VisitBankAndStoreGold instance = new VisitBankAndStoreGold();

    private VisitBankAndStoreGold()
    {
        
    }

    public override GameObject target
    {
        get
        {
            return Directory.instance.bank;
        }
    }
    public override void Enter(Miner entity)
    {
        entity.goldInBank += entity.goldPerson;
        entity.goldPerson = 0;
    }

    public override void Execute(Miner entity)
    {
        if (UnityEngine.Random.Range(0f, 1f) < .1f)
        {
            entity.stateMachine.TravelTo(GoHomeAndRestTillRested.instatance);
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
