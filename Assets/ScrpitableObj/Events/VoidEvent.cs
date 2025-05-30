using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Event")]
public class VoidEvent : ScripableObjBase
{

    public UnityAction onEventRaised;

    public void RaiseEvent()
    {
        onEventRaised?.Invoke();
    }

    public void Subscribe(UnityAction function)
    {
        onEventRaised += function;
    }
    public void UnSubscribe(UnityAction function)
    {
        onEventRaised -= function;
    }
}