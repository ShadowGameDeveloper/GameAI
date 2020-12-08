using UnityEngine;
using System.Collections;

public class ElsaEat : State<Elsa>
{
    public static ElsaEat instance = new ElsaEat();

    public ElsaEat()
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
            entity.stateMachine.TravelTo(DoHouseWork.instance);
        }
    }

    public override void Exit(Elsa entity)
    {

    }

    public override bool handelMassage(Elsa enity, Telegram tele)
    {
        return false;
    }

   
}
