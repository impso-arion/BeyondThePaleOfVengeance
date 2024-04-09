using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Scene1からScene2への遷移を行う関数
    public void GoToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // Scene2からScene1への遷移を行う関数
    public void GoToBeginningScene()
    {
        SceneManager.LoadScene("BeginningScene");
    }
}
