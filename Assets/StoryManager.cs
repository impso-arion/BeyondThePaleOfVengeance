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
    //ストーリーのエレメント配列番号が必要なのでプロパティを
    public int storyIndex { get; private set; }
    public int textIndex { get; private set; }

    //テキストがすべて表示されたかどうか
    private bool finishText = true;
        
    private void Start()
    {
        //テキスト部を初期化して
        storyText.text = "";
        characterName.text = "";
        SetStoryElement(storyIndex, textIndex);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && finishText)
        {
            textIndex++;//インデックスを増やす
            //テキスト部を初期化して
            storyText.text = "";
            characterName.text = "";
            ProgressionStory(storyIndex);
        }
    }

    //呼び出し方は
    private void SetStoryElement(int _storyIndex, int _textIndex)
    {
        //同じ言葉をまとめておくためのvar
        var storyElement = storyDatas[_storyIndex].stories[_textIndex];
        //どのストーリーデータの、どのバックグランドか
        background.sprite = storyElement.Background;
        //どのストーリーデータの、どのキャラクタか
        characterImage.sprite = storyElement.CharacterImage;
        
        //どのストーリーデータの、どのキャラ名か
        characterName.text = storyElement.CharacterName;
        //どのストーリーデータの、どのテキストか
        //storyText.text = storyElement.StoryText;
        //1文字づつ表示するコルーチン
        StartCoroutine(TypeSentence(_storyIndex, _textIndex));

    }

    private void ProgressionStory(int _storyIndex)
    {
        //ストーリーインデックスよりも大きいテキストは存在しないのでチェックして対応
        //最後まで行ったなら、次のお話などに進めたいですよね
        if(textIndex < storyDatas[_storyIndex].stories.Count)
        {
            //まだ大きくないなら次のインデックスを表示
            SetStoryElement(_storyIndex, textIndex);
        }
        else
        {
            //シーンチェンジや選択肢の表示。スクリプタブルオブジェクトを呼んだり。
            ChangeStoryElement(_storyIndex);
        }
    }

    private void ChangeStoryElement(int _storyIndex)
    {
        textIndex = 0;
        storyIndex++;//次のシーンへ
        SetStoryElement(_storyIndex, textIndex);
    }

    //文字を1文字づつ表示するコルーチン
    private IEnumerator TypeSentence(int _storyIndex,int _textIndex)
    {
        //１文字づつ文字を分割した状態にする
        foreach(var letter in storyDatas[_storyIndex].stories[_textIndex].StoryText.ToCharArray())
        {
            finishText = false;
            storyText.text += letter;//1文字表示
            yield return new WaitForSeconds(0.05f);
        }
        //すべて表示されたら次の文に行けます
        finishText = true;
    }


}
