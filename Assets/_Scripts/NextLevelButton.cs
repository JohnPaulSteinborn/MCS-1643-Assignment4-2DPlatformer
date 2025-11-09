using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    public string NextLevel = "Level0";

    public void OnClick()
    {
        SceneManager.LoadScene(NextLevel);
    }
}
