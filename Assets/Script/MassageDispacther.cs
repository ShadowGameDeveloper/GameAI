using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class MassageDispacther
{
    public static MassageDispacther instance = new MassageDispacther();
    public MassageDispacther()
    {

    }

    SortedList<DateTime, Telegram> telegramss = new SortedList<DateTime, Telegram>();

    public void DispatchMassage(TimeSpan delay, BaseGameEntity sender, BaseGameEntity reciever, int msg)
    {
        var telegram = new Telegram(sender,reciever,msg,DateTime.Now + delay);
        if(delay == TimeSpan.Zero)
        {
            Discharge(telegram);
        }
        else
        {
            telegramss.Add(telegram.dispatchTime, telegram);
        }
    }

    private void Discharge(Telegram telegram)
    {
        telegram.reciever.HandleMassage(telegram);
    }
}
