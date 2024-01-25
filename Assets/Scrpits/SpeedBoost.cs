using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    float speedAdd = 5;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.TryGetComponent<PhysicsCharacterController>(out PhysicsCharacterController player))
        {

            player.addSpeed(speedAdd);


        }

    }
}

