using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
    [SerializeField] protected float hp;
    [SerializeField] protected int points;
    [SerializeField] protected IntEvent scoreEvent;

    [SerializeField] protected GameObject hitPrefab;
    [SerializeField] protected GameObject destoryPrefab;

    
	public void ApplyDamage(float damage)
	{
        hp -= damage;
		if (hp < 0)
		{
            scoreEvent?.RaiseEvent(points);
            if(destoryPrefab != null)
			{
                Instantiate(destoryPrefab, gameObject.transform.position, Quaternion.identity);
			}
            Destroy(gameObject);
		}
		else
		{
            if (hitPrefab != null)
            {
                Instantiate(hitPrefab, gameObject.transform.position, Quaternion.identity);
            }
        }
	}

}
