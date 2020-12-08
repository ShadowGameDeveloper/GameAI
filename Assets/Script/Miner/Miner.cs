using UnityEngine;
using System.Collections;
using System;

public class Miner : BaseGameEntity
{
    public static Miner instance = new Miner();
    public StateMAchine<Miner> stateMachine;
   
    public int goldPerson;
    public int goldInBank;
    public int fatigue;

    public Miner()
    {

    }

    protected void Start()
    {
        instance = this;
        stateMachine = new StateMAchine<Miner>(this, EnterMineAndDigForNugget.instance,MinerGlobalState.instance);    
        
    }
    
    internal bool PocketFull()
    {
        return goldPerson > 1000;
    }

   

    protected void FixedUpdate()
    {
        stateMachine.Execute();
    }

    public override void HandleMassage(Telegram tele)
    {
        stateMachine.HandleMassage(tele);
    }
}
