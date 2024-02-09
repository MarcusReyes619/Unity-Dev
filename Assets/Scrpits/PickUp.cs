using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] GameObject pickupPrefab = null;
    // Start is called before the first frame update

    [SerializeField] public AudioClip sound;
    private void OnCollisionEnter(Collision collision)
	{
        print(collision.gameObject.name);
        
        Instantiate(pickupPrefab, transform.position, Quaternion.identity);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Addpoints(10);
            AudioSource.PlayClipAtPoint(sound, transform.position, 1f);
        }
        


      
        Destroy(gameObject);
    }
}
