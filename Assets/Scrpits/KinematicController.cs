using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicController : MonoBehaviour
{
    [SerializeField, Range(0, 40)] float speed = 1;
    [SerializeField, Range(0, 40)] float maxDistance = 5;
    [SerializeField, Range(0, 40)] float roationAngle = 10;
    [SerializeField, Range(0, 40)] float roationRate= 10;
    public float health = 100.0f;
    
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");

        Vector3 force = dir * speed * Time.deltaTime;
        transform.localPosition += force;

        Quaternion qyaw = Quaternion.AngleAxis(dir.x * 20, Vector3.up);
        Quaternion qpitch = Quaternion.AngleAxis(-dir.y * 20, Vector3.right);

        Quaternion rotation = qyaw * qpitch;

        transform.localRotation = Quaternion.Lerp(transform.localRotation, rotation, 10);

    }

    public void ApplyDamage(float damage)
    {
        health -= damage;
    }

}