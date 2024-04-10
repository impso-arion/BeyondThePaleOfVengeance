using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ImageClick : MonoBehaviour, IPointerClickHandler
{
    SelectGame selectGame;
    SelectGame2 selectGame2;

    [SerializeField] private TextMeshProUGUI storyText;
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] public GameObject objCharacterName;
    [SerializeField] public GameObject objTextWindow;
    [SerializeField] public GameObject Clicks;
    [SerializeField] private GameObject koban;

    private void Start()
    {
        
        selectGame = FindObjectOfType<SelectGame>();//onGame��bool�擾�p
        selectGame2 = FindObjectOfType<SelectGame2>();//onGame��bool�擾�p
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        string sendStoryText = "";
        switch (gameObject.tag)
        {
            case "osiire2":
                // �^�O�� "Player" �̏ꍇ�̏���
                Debug.Log("��������Q�ł�");
                // �����Ƀv���C���[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "�������ꂾ�ȁA�z�c�����܂��Ă���B";
                textIndicate(sendStoryText);
                break;
            case "osiire":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("��������ł�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "�������ꂾ�ȁA�����Ⴒ���Ⴕ�����̂����܂��Ă���B";
                textIndicate(sendStoryText);
                break;
            case "nanbanDana":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("��ؒI�ł�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "��ؒI���ȁA���������Ƃ���ɑ�؂Ȃ��̂��B�����������E�E�E�E�E�E\n��������Ȃ�";
                textIndicate(sendStoryText);
                break;
            case "bin":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("����̏��r���ł�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "����̏��r���ȁA�K���N�^����˂����B";
                textIndicate(sendStoryText);
                break;
            case "rousoku":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("�낤�����ł���");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "�낤�������A���邢�B���̂ւ�ɂ͉����������B";
                textIndicate(sendStoryText);
                break;
            case "sitai":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("��l�̎��̂�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "��l�̎��̂��A�܂����������Ă�E�E�E";
                textIndicate(sendStoryText);
                break;
            case "sitai1":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("��l�̎��̂��ȁA�ʂ̕���");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "��l�̎��̂��E�E�E��������ł邾�낤�Ȃ��E�E�E";
                textIndicate(sendStoryText);
                break;
            case "tukue":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("�����ł�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "�������B���ނ����邪�A\n�Ȃ�Ƃ����ɂȂ肻�����ǂ����͂킩��˂��B";
                textIndicate(sendStoryText);
                break;
            case "kobinn":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("���r���Ȃ��ł���");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "���r���B���̒��ɋ����E�E�E�Ȃ�ĂȁB�Ȃɂ��Ȃ��B";
                textIndicate(sendStoryText);
                break;
            case "akari":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("�����肾");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "�����肪�Ƃ����Ă���";
                textIndicate2(sendStoryText);
                break;
            case "kusuribin":
                // �^�O�� "kusuribin" �̏ꍇ�̏���
                Debug.Log("��r��");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "��r���B��H����́H���₵����ݎ�";
                getMoneyIndicate1(sendStoryText);
                break;
            case "fusuma":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("�ӂ��܂�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "�ӂ��܂̌������ɂ͉����Ȃ�";
                textIndicate2(sendStoryText);
                break;
            case "tinoato":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("���̂��Ƃ�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                sendStoryText = "���̂������܂Ŕ��ł���B\n���������Ή����Ԃ茌�܂݂ꂾ�B";
                textIndicate2(sendStoryText);
                break;
            default:
                // ���̑��̃^�O�̏ꍇ�̏���
                Debug.Log("�Ȃɂ��Ȃ��Ƃ��낾");
                // �����ɂ��̑��̃I�u�W�F�N�g�Ɋ֘A���鏈�����L�q���܂�
                break;
        }
    }

    void textIndicate(string _storyText)//�e�L�X�g�o�͗pSelectGame1
    {
        Clicks.SetActive(false);
        objCharacterName.SetActive(true);
        objTextWindow.SetActive(true);
        storyText.text = _storyText;
        characterName.text = "�s��Y";
        selectGame.onGame = false;
    }
    void textIndicate2(string _storyText)//�e�L�X�g�o�͗pSelectGame2
    {
        Clicks.SetActive(false);
        objCharacterName.SetActive(true);
        objTextWindow.SetActive(true);
        storyText.text = _storyText;
        characterName.text = "�s��Y";
        selectGame2.onGame2 = false;
    }
    void getMoneyIndicate1(string _storyText)//�e�L�X�g�o�͗pSelectGame2
    {
        Clicks.SetActive(false);
        objCharacterName.SetActive(true);
        objTextWindow.SetActive(true);
        koban.SetActive(true) ;
        storyText.text = "��������ɓ��ꂽ�B���ꂾ���ł͑����ɂȂ�܂����A�ܗ��߂����肻�����B";
        characterName.text = "�s��Y";
        selectGame2.getMoney = true;//true�ɂ���ƁA�G���f�B���O�ցB
        selectGame2.onGame2 = false;
    }
    
}