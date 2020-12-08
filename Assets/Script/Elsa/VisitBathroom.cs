using UnityEngine;
using System.Collections;

public class VisitBathroom : State<Elsa>
{
    public static VisitBathroom instance = new VisitBathroom();

    private VisitBathroom()
    {

    }
    public override GameObject target
    {
        get
        {
            return Directory.instance.outHouse;
        }
    }

    public override void Enter(Elsa entity)
    {
        
    }

    public override void Execute(Elsa entity)
    {
        if (UnityEngine.Random.Range(0f, 1f) < 0.001f)
        {
            entity.stateMachine.TravelTo(DoHouseWork.instance);
        }
    }

    public override void Exit(Elsa entity)
    {
        
    }

    public override bool handelMassage(Elsa entity, Telegram tele)
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
