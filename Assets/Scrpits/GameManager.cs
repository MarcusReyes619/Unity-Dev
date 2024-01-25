using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] GameObject titleUI;
    [SerializeField] GameObject deadUI;
    [SerializeField] TMP_Text livesUI;
    [SerializeField] TMP_Text timerUI;
    [SerializeField] Slider healthUI;
    [SerializeField] FlaotVar health;

    [Header("Event")]
    [SerializeField] IntEvent scoreEvent;

    public enum State
	{
        TITLE,
        START_GAME,
        PLAY_GAME,
        GAME_OVER
	}

    public State state = State.TITLE;
    public float timer = 0;
    public int lives = 0;

    public int Lives { get { return lives; } 
        set { lives = value; livesUI.text = "Lives" + lives.ToString(); } }

    public float Timer
    {


        get { return timer; }
        set
        {
            timer = value;
            timerUI.text = string.Format("{0:F1}", timer.ToString()); 
        }
    }
    void Start()
    {
        scoreEvent.Subscribe(OnAddPoint);
    }

    // Update is called once per frame
    void Update()
    {
		switch (state)
		{
			case State.TITLE:
                titleUI.SetActive(true);
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
				break;
			case State.START_GAME:
                titleUI.SetActive(false);
                deadUI.SetActive(false);
                timer = 60;
                health.value = 100;
                lives = 3;
                state = State.PLAY_GAME;
				break;
			case State.PLAY_GAME:
				if (healthUI.value <=0)
				{
                    print("ENd");
                    state = State.GAME_OVER;
                }
                if(timer <= 0)
				{
                    state = State.GAME_OVER;
				}
                Timer = Timer - Time.deltaTime;
				break;
			case State.GAME_OVER:
                deadUI.SetActive(true);
               // state = State.TITLE;
				break;
		}

        healthUI.value = health.value / 100.0f;

       
	}



    public void OnStartGame()
	{
        state = State.START_GAME;
	}

    public void OnAddPoint(int points)
    {
        print(points);
    }

    public void TimeAdd()
    {
        Timer += 5.0f;
    }
}
