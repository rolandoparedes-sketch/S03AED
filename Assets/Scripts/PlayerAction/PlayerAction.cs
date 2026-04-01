using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;
public enum PlayerAction
{
    Mover,
    Atacar,
    Defender
}
public class ActionNode
{
    public PlayerAction action;
    public ActionNode next;

    public ActionNode(PlayerAction action)
    {
        this.action = action;
        this.next = null;
    }
}
