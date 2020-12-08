using UnityEngine;
using System.Collections;
using System;
public class Elsa : BaseGameEntity 
{
    public StateMAchine<Elsa> stateMachine;
    public static Elsa instance;
    public DateTime lastDinner;
    public Elsa()
    {

    }
    

    protected void Start()
    {
        instance = this;
        stateMachine = new StateMAchine<Elsa>(this, DoHouseWork.instance, ElsaGlobalState.instance);

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
