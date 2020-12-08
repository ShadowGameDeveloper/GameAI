using UnityEngine;
using System.Collections;
using System;

public class Telegram
{
    public readonly BaseGameEntity sender, reciever;
    public readonly int msg;
    public readonly DateTime dispatchTime;
   
    public Telegram(BaseGameEntity sender, BaseGameEntity reciever, int msg, DateTime dispatchTime)
    {
        this.sender = sender;
        this.reciever = reciever;
        this.msg = msg;
        this.dispatchTime = dispatchTime;

    }
}
