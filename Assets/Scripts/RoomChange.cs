using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RoomChange : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public GameObject selectGame1Canvas;
    public GameObject selectGame2Canvas;

    

    public void ShowDialog()
    {
        dialogText.text = "となりの部屋に移動しようか・・・";
        dialogBox.SetActive(true);
    }

    public void YesButtonClicked()
    {

        // Yesボタンがクリックされたときの処理
        Debug.Log("Yes button clicked!");
        //canbas切換
        selectGame2Canvas.SetActive(true);
        selectGame1Canvas.SetActive(false);
        dialogBox.SetActive(false);
    }

    public void NoButtonClicked()
    {
        // Noボタンがクリックされたときの処理
        Debug.Log("No button clicked!");
        dialogBox.SetActive(false);
    }
}
