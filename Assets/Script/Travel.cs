using UnityEngine;

internal class Travel<EntityType> : State<EntityType> where EntityType : BaseGameEntity
{
    
    private State<EntityType> newState;

    public Travel(State<EntityType> newState)
    {
        this.newState = newState;
    }

    public override GameObject target
    {
        get
        {
            return null;
        }
    }

    public override void Enter(EntityType entity)
    {

    }

    public override void Execute(EntityType entity)
    {

    }

    public override void Exit(EntityType entity)
    {

    }

    public override bool handelMassage(EntityType entity, Telegram tele)
    {
        return false;
    }
}