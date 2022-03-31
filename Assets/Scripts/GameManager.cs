using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //extra credit for, custom made obstacles, sketchup is for free, import custom made obstacle

    public GameObject floor;
    public GameObject pinBall;
    public int score = 0;
    public static GameManager Instance;
    public GameState gameState;
    public static event Action<GameState> OnGameStateChanged;
    public TMP_Text scoreboard;



    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        UpdateGameState(GameState.Idle);

    }

    public void UpdateGameState(GameState newState)
    {


        switch (newState)
        {
            case GameState.Idle:
                gameState = GameState.Idle;
                break;
            case GameState.Playing:
                
                break;
            case GameState.WinLevel:
                

                break;
            case GameState.LoseLevel:
                break;
            case GameState.WinGame:
                break;
            case GameState.GameOver:
                break;
        }

        OnGameStateChanged?.Invoke(newState);
    }



    public void FixedUpdate()
    {
        //set text UI for collected points
        scoreboard.SetText("score: " + score);



    }

    public enum GameState
    {
        Idle,
        Playing,
        WinLevel,
        LoseLevel,
        WinGame,
        GameOver
    }

}
