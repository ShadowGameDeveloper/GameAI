using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGameEntity : MonoBehaviour
{
    public float moveSpeed = 0.01f;

    public abstract void HandleMassage(Telegram tele);
}
