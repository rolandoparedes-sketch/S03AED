using UnityEngine;

public class ActionList
{
    public ActionNode head;

    public void AddAction(PlayerAction action)
    {
        ActionNode newNode = new ActionNode(action);
        if (head == null)
        {
            head = newNode;
        }

        ActionNode current = head;
        while (current.next != null)
        {
            current = current.next;
        }

        current.next = newNode;
    }
}

