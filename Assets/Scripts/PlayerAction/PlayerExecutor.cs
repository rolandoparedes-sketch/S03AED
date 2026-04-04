using UnityEngine;
using System.Collections;

public class PlayerActionExecutor : MonoBehaviour
{
    public ActionList lista = new ActionList();

    void Start()
    {
        
        lista.AddAction(PlayerAction.Mover);
        lista.AddAction(PlayerAction.Atacar);
        lista.AddAction(PlayerAction.Mover);
        lista.AddAction(PlayerAction.Defender);

        StartCoroutine(Ejecutar());
    }

    IEnumerator Ejecutar()
    {
        ActionNode actual = lista.head;

        while (actual != null)
        {
            if (actual.action == PlayerAction.Mover)
            {
                transform.position += Vector3.forward;
            }
            else if (actual.action == PlayerAction.Atacar)
            {
                Debug.Log("Atacar");
            }
            else if (actual.action == PlayerAction.Defender)
            {
                Debug.Log("Defender");
            }

            yield return new WaitForSeconds(1f);
            actual = actual.next;
        }
    }
}