using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disco : MonoBehaviour
{
    // Start is called before the first frame update

    public Light discoLight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        discoLight.color = Color.HSVToRGB(Random.Range(0, 255), 1.0f,1.0f);   
    }
}
