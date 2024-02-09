using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour, IDamagable
{
    // Start is called before the first frame update
    [SerializeField] private PathFollower pathflower;
    [SerializeField] private Inventory inventory;
    [SerializeField] private IntEvent scoreEvent;
    [SerializeField] private Action action;
    [SerializeField] private IntVar scroe;
    [SerializeField] private FlaotVar hp;


    

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            inventory.Use();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            inventory.OnStopUse();
        }

        pathflower.speed = Input.GetKeyDown(KeyCode.Space) ? 2 : 1 ;
	

		
    }
	public void Start()
	{
        
        hp.value = 100;
	}
	public void Addpoints(int point)
	{
        scroe.value += point;
        Debug.Log(scroe.value);
	}

	public void ApplyDamage(float damage)
	{
		
	}

    public void ApplyHelth(float hp)
	{
        this.hp.value += hp;
      //  this.hp.value = Mathf.Min(this.hp, 100);
	}
}
