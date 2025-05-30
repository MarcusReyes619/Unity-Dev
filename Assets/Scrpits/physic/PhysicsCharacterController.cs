using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsCharacterController : MonoBehaviour
{

    [Header("Movement")] 

    [SerializeField][Range(1,10)] float maxForce = 5;
    [SerializeField][Range(1,10)] float jumpForce = 5;
    [SerializeField] Transform view;
    [Header("Collision")]
    [SerializeField] [Range(0, 5)] float rayLength = 1;
    [SerializeField] LayerMask groundLayerMask;

    Rigidbody rb;
    Vector3 force = Vector3.zero;
    float forceMultiplier = 1;
    void Start()
    {
 
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        Quaternion yrotation = Quaternion.AngleAxis(view.rotation.eulerAngles.y, Vector3.up);
        force = yrotation * direction * maxForce;

        Debug.DrawRay(transform.position, Vector3.down * rayLength, Color.red);
        if (Input.GetButtonDown("Jump") && CheckGround())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpForce = 5;
        }

        forceMultiplier -= Time.deltaTime * 0.2f;
        forceMultiplier = Mathf.Clamp(forceMultiplier, 1, 5);
    }

   
	private void FixedUpdate()
	{
        rb.AddForce(force * forceMultiplier, ForceMode.Force);
	} 

    public void addSpeed(float speedAdd)
	{
        forceMultiplier = speedAdd;
	}

    public bool WEEEEEE(float jumpAdd, bool contact)
    {

        rb.AddForce(Vector3.up * jumpAdd, ForceMode.Impulse);


        return false;
    }

    private bool CheckGround() 
	{
        
        return Physics.Raycast(transform.position, Vector3.down, rayLength, groundLayerMask);
        
	}
}
