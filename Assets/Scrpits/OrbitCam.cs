using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCam : MonoBehaviour
{
    [SerializeField] Transform target = null;
    [SerializeField] [Range(20, 90)] float defultPitch = 40;
    [SerializeField] [Range(2, 8)] float distance = 5;
    [SerializeField] [Range(20, 90)] float sens = 1;

    float yaw = 0;
    float pitch = 0;

    private void Start()
    {
        pitch = defultPitch;
    }

    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * sens;

        Quaternion qyaw = Quaternion.AngleAxis(yaw, Vector3.up);
		Quaternion qpitch = Quaternion.AngleAxis(pitch, Vector3.right);
		Quaternion rotation = qyaw * qpitch;

		transform.position = target.position + (rotation *Vector3.back * distance);
        transform.rotation = rotation;
    }
}
