using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField][Range(1,20)][Tooltip("Force to move object")] float force;

    private void Awake()
    {
        print("Awake");
        

    }

    void Start()
    {
        print("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * force, ForceMode.VelocityChange);
        }
    }
}
