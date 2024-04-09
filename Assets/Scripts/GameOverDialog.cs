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
        dialogText.text = "�Ԃ�V���Q�Ă��邪�E�E�E\n�ƂȂ�̕����Ɉړ����悤���E�E�E";
        dialogBox.SetActive(true);
    }

    public void YesButtonClicked()
    {
        // Yes�{�^�����N���b�N���ꂽ�Ƃ��̏���
        Debug.Log("Yes button clicked!");
        //canbas�؊�
        mainCanvas.SetActive(true);
        selectGame2Canvas.SetActive(false);

        //storyManager���Ăяo���B
        storyManager.SetStoryIndex(2);
        storyManager.SetStoryElement(2, 0);//�Q�[���I�[�o�[�̊J�n

        dialogBox.SetActive(false);
    }

    public void NoButtonClicked()
    {
        // No�{�^�����N���b�N���ꂽ�Ƃ��̏���
        Debug.Log("No button clicked!");
        dialogBox.SetActive(false);
    }
}