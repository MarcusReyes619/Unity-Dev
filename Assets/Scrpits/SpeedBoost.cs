using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    float speedAdd = 0;

    private void OnTriggerStay(Collider other)
	{

        if (other.gameObject.TryGetComponent<PhysicsCharacterController>(out PhysicsCharacterController player))
        {
            if (speedAdd <= 15)
            {
                speedAdd += Time.deltaTime * 2f;
            }
            else speedAdd = 15.0f;
			

        }
      
    }

	private void OnTriggerExit(Collider other)
	{
        if (other.gameObject.TryGetComponent<PhysicsCharacterController>(out PhysicsCharacterController player))
        {
            player.addSpeed(speedAdd);
        }
    }
}
