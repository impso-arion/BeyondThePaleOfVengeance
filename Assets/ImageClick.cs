using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ImageClick : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        switch (gameObject.tag)
        {
            case "osiire2":
                // �^�O�� "Player" �̏ꍇ�̏���
                Debug.Log("��������Q�ł�");
                // �����Ƀv���C���[�Ɋ֘A���鏈�����L�q���܂�
                break;
            case "osiire":
                // �^�O�� "Enemy" �̏ꍇ�̏���
                Debug.Log("��������ł�");
                // �����ɃG�l�~�[�Ɋ֘A���鏈�����L�q���܂�
                break;
            default:
                // ���̑��̃^�O�̏ꍇ�̏���
                Debug.Log("���̑��̃I�u�W�F�N�g�ł�");
                // �����ɂ��̑��̃I�u�W�F�N�g�Ɋ֘A���鏈�����L�q���܂�
                break;
        }
    }
}