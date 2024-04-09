using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomChange1 : MonoBehaviour
{
    SelectGame2 selectGame2;
    StoryManager storyManager;
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public GameObject selectGame1Canvas;
    public GameObject selectGame2Canvas;
    public GameObject mainCanvas;
    
    private void Start()
    {
        selectGame2 = FindObjectOfType<SelectGame2>();//フラグチェックのため
        storyManager = FindObjectOfType<StoryManager>();//クリアストーリーへ
    }

    public void ShowDialog()
    {
        dialogText.text = "さっきの部屋に移動しようか・・・";
        dialogBox.SetActive(true);
    }

    public void YesButtonClicked()
    {
        if (selectGame2.getMoney)
        {
            Debug.Log("お金あるのでエンディングへ");
            // Yesボタンがクリックされたときの処理
            Debug.Log("Yes button clicked!");
            //canbas切換
            mainCanvas.SetActive(true);
            selectGame2Canvas.SetActive(false);
            //storyManagerを呼び出す。
            storyManager.SetStoryIndex(3);
            storyManager.SetStoryElement(3, 0);//クリアシナリオの開始
            dialogBox.SetActive(false);
        }
        else
        {
            // Yesボタンがクリックされたときの処理
            Debug.Log("Yes button clicked!");
            //canbas切換
            selectGame1Canvas.SetActive(true);
            selectGame2Canvas.SetActive(false);
            dialogBox.SetActive(false);
        }
        
    }

    public void NoButtonClicked()
    {
        // Noボタンがクリックされたときの処理
        Debug.Log("No button clicked!");
        dialogBox.SetActive(false);
    }
}
