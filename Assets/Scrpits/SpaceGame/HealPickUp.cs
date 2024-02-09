using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickUp : MonoBehaviour
{
	[SerializeField] float hp;
	[SerializeField] GameObject pickUpPrefab;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.TryGetComponent(out PlayerShip player))
		{
			player.ApplyHelth(hp);
			if(pickUpPrefab != null) Instantiate(pickUpPrefab, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}

}
