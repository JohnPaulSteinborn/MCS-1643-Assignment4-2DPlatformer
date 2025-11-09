using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI ScoreboardTMP;
    public GameObject[] LifeToken;
    public GameObject GameOverScreen;

    private void Start()
    {
        GameOverScreen.SetActive(false);
    }
    private void Update()
    {
        if (GameManager._gameOver)
        {
            GameOverScreen.SetActive(true);
            return;
        }
        ScoreboardTMP.text = GameManager.Score.ToString();

        //hide all the tokens in the ui
        for(int i = 0; i < LifeToken.Length; i++)
        {
            LifeToken[i].SetActive(false);
        }

        // reveal the correct number of tokens for lives
        for (int i = 0; i < GameManager.Lives; i++)
        {
            LifeToken[i].SetActive(true);
        }
    }
}
