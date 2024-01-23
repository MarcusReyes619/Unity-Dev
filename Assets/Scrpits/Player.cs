using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] FlaotVar health;
    [Header("Event")]
    [SerializeField] IntEvent scoreEvent = default;
    [SerializeField] TMP_Text scoreText;
  


    private int score = 0;

    public int Score { get { return score; } 
        set { score = value;
            scoreText.text = score.ToString();
            scoreEvent.RaiseEvent(score);
        } }

    public void Start()
    {
        health.value = 5.5f;
        
    }

    // public int Score { get { return score; } set { scoreText.text = Score.ToString; } }

    public void Addpoints(int points)
    {
        Score += points;

       

    }

    public void Dmg(float dmg)
    {
        health.value -= dmg;
    }

    public void OnRespawn(GameObject respawn)
    {
        transform.position = respawn.transform.position;
        
    }
}
