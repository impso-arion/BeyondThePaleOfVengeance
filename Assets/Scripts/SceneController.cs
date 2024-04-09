using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Scene1����Scene2�ւ̑J�ڂ��s���֐�
    public void GoToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // Scene2����Scene1�ւ̑J�ڂ��s���֐�
    public void GoToBeginningScene()
    {
        SceneManager.LoadScene("BeginningScene");
    }
}
