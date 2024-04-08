using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    [SerializeField] private StoryData[] storyDatas;
    [SerializeField] private Image background;
    [SerializeField] private Image characterImage;
    [SerializeField] private TextMeshProUGUI storyText;
    [SerializeField] private TextMeshProUGUI characterName;
    //�X�g�[���[�̃G�������g�z��ԍ����K�v�Ȃ̂Ńv���p�e�B��
    public int storyIndex { get; private set; }
    public int textIndex { get; private set; }

    //�e�L�X�g�����ׂĕ\�����ꂽ���ǂ���
    private bool finishText = true;
        
    private void Start()
    {
        //�e�L�X�g��������������
        storyText.text = "";
        characterName.text = "";
        SetStoryElement(storyIndex, textIndex);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && finishText)
        {
            textIndex++;//�C���f�b�N�X�𑝂₷
            //�e�L�X�g��������������
            storyText.text = "";
            characterName.text = "";
            ProgressionStory(storyIndex);
        }
    }

    //�Ăяo������
    private void SetStoryElement(int _storyIndex, int _textIndex)
    {
        //�������t���܂Ƃ߂Ă������߂�var
        var storyElement = storyDatas[_storyIndex].stories[_textIndex];
        //�ǂ̃X�g�[���[�f�[�^�́A�ǂ̃o�b�N�O�����h��
        background.sprite = storyElement.Background;
        //�ǂ̃X�g�[���[�f�[�^�́A�ǂ̃L�����N�^��
        characterImage.sprite = storyElement.CharacterImage;
        
        //�ǂ̃X�g�[���[�f�[�^�́A�ǂ̃L��������
        characterName.text = storyElement.CharacterName;
        //�ǂ̃X�g�[���[�f�[�^�́A�ǂ̃e�L�X�g��
        //storyText.text = storyElement.StoryText;
        //1�����Â\������R���[�`��
        StartCoroutine(TypeSentence(_storyIndex, _textIndex));

    }

    private void ProgressionStory(int _storyIndex)
    {
        //�X�g�[���[�C���f�b�N�X�����傫���e�L�X�g�͑��݂��Ȃ��̂Ń`�F�b�N���đΉ�
        //�Ō�܂ōs�����Ȃ�A���̂��b�Ȃǂɐi�߂����ł����
        if(textIndex < storyDatas[_storyIndex].stories.Count)
        {
            //�܂��傫���Ȃ��Ȃ玟�̃C���f�b�N�X��\��
            SetStoryElement(_storyIndex, textIndex);
        }
        else
        {
            //�V�[���`�F���W��I�����̕\���B�X�N���v�^�u���I�u�W�F�N�g���Ă񂾂�B
            ChangeStoryElement(_storyIndex);
        }
    }

    private void ChangeStoryElement(int _storyIndex)
    {
        textIndex = 0;
        storyIndex++;//���̃V�[����
        SetStoryElement(_storyIndex, textIndex);
    }

    //������1�����Â\������R���[�`��
    private IEnumerator TypeSentence(int _storyIndex,int _textIndex)
    {
        //�P�����Â����𕪊�������Ԃɂ���
        foreach(var letter in storyDatas[_storyIndex].stories[_textIndex].StoryText.ToCharArray())
        {
            finishText = false;
            storyText.text += letter;//1�����\��
            yield return new WaitForSeconds(0.05f);
        }
        //���ׂĕ\�����ꂽ�玟�̕��ɍs���܂�
        finishText = true;
    }


}
