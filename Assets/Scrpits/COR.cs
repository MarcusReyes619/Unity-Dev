using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COR : MonoBehaviour
{
    [SerializeField] float time = 3;
    [SerializeField] bool go = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer(time));
        StartCoroutine(StoryTime());
        StartCoroutine(WaitAction());
    }

    // Update is called once per frame
    void Update()
    {
        //time -= Time.deltaTime;
        //if(time <= 0)
        //{
        //    time = 3;
        //    print("hello");
        //}
    }

    IEnumerator Timer(float time)
    {
        for (; ; )
        {
            yield return new WaitForSeconds(time);
            //check pereption
            print("hello");
            
        }
    }

    IEnumerator WaitAction()
    {
        yield return new WaitUntil(() => go);
        print("go");
    }

    IEnumerator StoryTime()
    {
        print("AHHHHHHHH");
        yield return new WaitForSeconds(1);
        print("kys");
        yield return new WaitForSeconds(1);
        print("like right now");

        
        yield return null;
    }
}
