using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverDialog : MonoBehaviour
{
    StoryManager storyManager;
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public GameObject mainCanvas;
    public GameObject selectGame2Canvas;


    private void Start()
    {
        storyManager = FindObjectOfType<StoryManager>();
    }


    public void ShowDialog()
    {
        dialogText.text = "赤ん坊が寝ているが・・・\nとなりの部屋に移動しようか・・・";
        dialogBox.SetActive(true);
    }

    public void YesButtonClicked()
    {
        // Yesボタンがクリックされたときの処理
        Debug.Log("Yes button clicked!");
        //canbas切換
        mainCanvas.SetActive(true);
        selectGame2Canvas.SetActive(false);

        //storyManagerを呼び出す。
        storyManager.SetStoryIndex(2);
        storyManager.SetStoryElement(2, 0);//ゲームオーバーの開始

        dialogBox.SetActive(false);
    }

    public void NoButtonClicked()
    {
        // Noボタンがクリックされたときの処理
        Debug.Log("No button clicked!");
        dialogBox.SetActive(false);
    }
}