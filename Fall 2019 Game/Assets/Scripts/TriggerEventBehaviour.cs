using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent, TriggerStayEvent, TriggerExitEvent;

    public void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
    

    private void OnTriggerStay(Collider other)
    {
        TriggerStayEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        TriggerExitEvent.Invoke();
    }
}