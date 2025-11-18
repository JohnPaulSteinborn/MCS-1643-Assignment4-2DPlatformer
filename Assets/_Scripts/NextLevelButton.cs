using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    public string NextLevel = "Level0";

    private AudioSource audioSrc;

    private void Awake()
    {
        audioSrc = GetComponentInChildren<AudioSource>();
    }

    public void OnClick()
    {
        audioSrc.Play();
        SceneManager.LoadScene(NextLevel);
    }
}
