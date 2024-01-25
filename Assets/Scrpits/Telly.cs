using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telly : MonoBehaviour
{
   
    [SerializeField] GameObject nextPostion;
    [SerializeField] public AudioClip sound;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {

            player.Telly(nextPostion.transform.position.x, 
                nextPostion.transform.position.y, 
                nextPostion.transform.position.z);
            AudioSource.PlayClipAtPoint(sound, transform.position, 1f);

        }
        Destroy(gameObject);
    }
}
