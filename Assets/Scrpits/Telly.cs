using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telly : PickUp
{
   
    [SerializeField] GameObject nextPostion;
    [SerializeField] Player player;
    

    protected override void Ablity()
    {
       player.Telly(nextPostion.transform.position.x,
       nextPostion.transform.position.y,
       nextPostion.transform.position.z);
       AudioSource.PlayClipAtPoint(sound, transform.position, 1f);
    }
    private new void OnTriggerEnter(Collider other)
    {

        base.OnTriggerEnter(other);
    }

   
}
