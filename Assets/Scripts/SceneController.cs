using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Scene1‚©‚çScene2‚Ö‚Ì‘JˆÚ‚ğs‚¤ŠÖ”
    public void GoToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }

    // Scene2‚©‚çScene1‚Ö‚Ì‘JˆÚ‚ğs‚¤ŠÖ”
    public void GoToBeginningScene()
    {
        SceneManager.LoadScene("BeginningScene");
    }
}
