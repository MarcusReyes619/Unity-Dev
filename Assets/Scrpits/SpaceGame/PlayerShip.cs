using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour, IDamagable
{
    // Start is called before the first frame update
    //[SerializeField] private PathFollower pathflower;
    //[SerializeField] private IntEvent scoreEvent;
    //[SerializeField] private Inventory inventory;
    //    [SerializeField] private Action action;

    //[SerializeField] private IntVar scroe;
    //[SerializeField] private FlaotVar hp;

    [SerializeField] private PathFollower pathFollower;
    [SerializeField] private Inventory inventory;
    [SerializeField] private IntEvent ScoreEvent;
    private Iterator<Item> iterator;
    [SerializeField] Action action;
    [SerializeField] IntVar score;
    [SerializeField] private FloatVar hp;

    [SerializeField] protected GameObject hitPrefab;
    [SerializeField] protected GameObject destroyPrefab;



    private void Start()
    {
        ScoreEvent.Subscribe(AddPoints);

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            inventory.Use();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            inventory.StopUse();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            while (!iterator.hasNext())
            {
                Debug.Log(iterator.next().GetData());
            }
        }
		
        pathFollower.speed = (Input.GetKey(KeyCode.Space)) ? 80.0f : 40.0f;
    }
    public void AddPoints(int points)
    {
        score.value += points;
        Debug.Log(score.value);
    }

    public void ApplyDamage(float damage)
    {
        
        hp.value -= damage;
        if (hp.value <= 0)
        {
            if (destroyPrefab != null)
            {
                Instantiate(destroyPrefab, gameObject.transform.position, Quaternion.identity);
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

    public void ApplyHealth(float hp)
    {
        this.hp.value += hp;
        this.hp.value = Mathf.Min(hp, 100);
    }
}