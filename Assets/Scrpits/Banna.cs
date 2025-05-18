using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banna : PickUp
{
    [SerializeField] int points;
    protected override void Ablity()
    {
        Player player = GameObject.Find("player").GetComponent<Player>();
        player.Addpoints(points);
    }

    private new void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

    }
}
