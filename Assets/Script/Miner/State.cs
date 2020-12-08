using UnityEngine;
using System.Collections;

public abstract class State<Entitype> where Entitype : BaseGameEntity
{
    public abstract GameObject target
    {
        get;
    }

    public abstract void Enter(Entitype entity);
    public abstract void Execute(Entitype entity);
    public abstract void Exit(Entitype entity);
    public abstract bool handelMassage(Entitype enity, Telegram tele);
}
