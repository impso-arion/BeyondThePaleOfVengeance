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
        dialogText.text = "�ƂȂ�̕����Ɉړ����悤���E�E�E";
        dialogBox.SetActive(true);
    }

    public void YesButtonClicked()
    {

        // Yes�{�^�����N���b�N���ꂽ�Ƃ��̏���
        Debug.Log("Yes button clicked!");
        //canbas�؊�
        selectGame2Canvas.SetActive(true);
        selectGame1Canvas.SetActive(false);
        dialogBox.SetActive(false);
    }

    public void NoButtonClicked()
    {
        // No�{�^�����N���b�N���ꂽ�Ƃ��̏���
        Debug.Log("No button clicked!");
        dialogBox.SetActive(false);
    }
}
