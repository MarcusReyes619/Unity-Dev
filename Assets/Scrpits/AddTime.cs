using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : PickUp
{
    protected override void Ablity()
    {
        GameManager.Instance.TimeAdd();
    }

  
    private new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        
    }
}
