using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    public Sprite ObjectiveCompleteSprite;
    public GameObject LevelCompleteScreen;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //change the sprite
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.sprite = ObjectiveCompleteSprite;

        //play some music/sound

        //pop up the level complete screen
        LevelCompleteScreen.SetActive(true);
    }
}
