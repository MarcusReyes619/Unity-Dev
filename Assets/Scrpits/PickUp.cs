using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    [SerializeField] GameObject pickupPrefab = null;
    // Start is called before the first frame update

    protected abstract void Ablity();

    [SerializeField] public AudioClip sound;
 

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            Ablity();
        }
        Destroy(gameObject);
    }
}
