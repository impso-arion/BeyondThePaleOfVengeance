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
        selectGame2 = FindObjectOfType<SelectGame2>();//�t���O�`�F�b�N�̂���
        storyManager = FindObjectOfType<StoryManager>();//�N���A�X�g�[���[��
    }

    public void ShowDialog()
    {
        dialogText.text = "�������̕����Ɉړ����悤���E�E�E";
        dialogBox.SetActive(true);
    }

    public void YesButtonClicked()
    {
        if (selectGame2.getMoney)
        {
            Debug.Log("��������̂ŃG���f�B���O��");
            // Yes�{�^�����N���b�N���ꂽ�Ƃ��̏���
            Debug.Log("Yes button clicked!");
            //canbas�؊�
            mainCanvas.SetActive(true);
            selectGame2Canvas.SetActive(false);
            //storyManager���Ăяo���B
            storyManager.SetStoryIndex(3);
            storyManager.SetStoryElement(3, 0);//�N���A�V�i���I�̊J�n
            dialogBox.SetActive(false);
        }
        else
        {
            // Yes�{�^�����N���b�N���ꂽ�Ƃ��̏���
            Debug.Log("Yes button clicked!");
            //canbas�؊�
            selectGame1Canvas.SetActive(true);
            selectGame2Canvas.SetActive(false);
            dialogBox.SetActive(false);
        }
        
    }

    public void NoButtonClicked()
    {
        // No�{�^�����N���b�N���ꂽ�Ƃ��̏���
        Debug.Log("No button clicked!");
        dialogBox.SetActive(false);
    }
}
