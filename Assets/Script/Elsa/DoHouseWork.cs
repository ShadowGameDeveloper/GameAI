using UnityEngine;
using System.Collections;

public class DoHouseWork : State<Elsa>
{
    public static DoHouseWork instance = new DoHouseWork();

    private DoHouseWork()
    {

    }

    public override GameObject target
    {
        get
        {
            return Directory.instance.home;
        }
    }

    public override void Enter(Elsa entity)
    {
        
    }

    public override void Execute(Elsa entity)
    {
        if(UnityEngine.Random.Range(0f,1f) < 0.001f)
        {
            entity.stateMachine.TravelTo(VisitBathroom.instance);
        }
    }

    public override void Exit(Elsa entity)
    {
        
    }

    public override bool handelMassage(Elsa entity,Telegram tele)
    {
        return false;
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
