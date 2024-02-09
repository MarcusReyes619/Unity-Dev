using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmg : MonoBehaviour
{
    [SerializeField] float dmg = 1;
    [SerializeField] bool oneTime = true;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Dmg(dmg);
            Debug.Log("REEEE");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!oneTime && other.gameObject.TryGetComponent<Player>(out Player player))
        {
            player.Dmg(dmg * Time.deltaTime);
            System.Console.WriteLine("work");
        }
    }
        
}

//public interface IDamagable
//{
//    void ApplyDamage(float damage);
//}
