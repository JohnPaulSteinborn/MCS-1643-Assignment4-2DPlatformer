using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PauseMenu;
    public static int Lives;
    public static int Score = 0;
    public static int LivesPerGame = 5;

    public static bool _paused;
    public static bool _gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.SetActive(false);
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!_paused)
            {
                Time.timeScale = 0;
                PauseMenu.SetActive(true);
                _paused = true;
            }
            else
            {
                Time.timeScale = 1;
                PauseMenu.SetActive(false);
                _paused = false;
            }
        }
    }

    public static void SubtractLife()
    {
        Lives--;

        Debug.Log($"Hit enemy! Lives left: {Lives}");
        if (Lives == 0)
        {
            //Game Over
            _gameOver = true;
        }
    }

    public static void StartGame()
    {
        Score = 0;
        Lives = LivesPerGame;
        _gameOver = false;
        _paused = false;
    }
}
