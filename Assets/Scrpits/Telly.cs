using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telly : MonoBehaviour
{
    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Telly(x, y, z);

        }
        Destroy(gameObject);
    }
}
