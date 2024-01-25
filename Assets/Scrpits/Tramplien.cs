using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramplien : MonoBehaviour
{
    [SerializeField] float jumpForce = 4;
    [SerializeField] public AudioClip sound;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.TryGetComponent<PhysicsCharacterController>(out PhysicsCharacterController player))
        {
            player.WEEEEEE(jumpForce, true);
            AudioSource.PlayClipAtPoint(sound, transform.position, 1f);

        }
        
    }

}
