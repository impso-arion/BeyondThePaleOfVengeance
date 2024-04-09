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
        
        selectGame = FindObjectOfType<SelectGame>();//onGameのbool取得用
        selectGame2 = FindObjectOfType<SelectGame2>();//onGameのbool取得用
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        string sendStoryText = "";
        switch (gameObject.tag)
        {
            case "osiire2":
                // タグが "Player" の場合の処理
                Debug.Log("押し入れ２です");
                // ここにプレイヤーに関連する処理を記述します
                sendStoryText = "押し入れ2だな";
                textIndicate(sendStoryText);
                break;
            case "osiire":
                // タグが "Enemy" の場合の処理
                Debug.Log("押し入れです");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "押し入れだな";
                textIndicate(sendStoryText);
                break;
            case "nanbanDana":
                // タグが "Enemy" の場合の処理
                Debug.Log("南蛮棚です");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "南蛮棚だな";
                textIndicate(sendStoryText);
                break;
            case "bin":
                // タグが "Enemy" の場合の処理
                Debug.Log("陶器の小ビンです");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "陶器の小瓶だな";
                textIndicate(sendStoryText);
                break;
            case "rousoku":
                // タグが "Enemy" の場合の処理
                Debug.Log("ろうそくですね");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "ろうそくだ";
                textIndicate(sendStoryText);
                break;
            case "sitai":
                // タグが "Enemy" の場合の処理
                Debug.Log("主人の死体だ");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "主人の死体だ";
                textIndicate(sendStoryText);
                break;
            case "sitai1":
                // タグが "Enemy" の場合の処理
                Debug.Log("主人の死体だな、別の部分");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "主人の死体の別の部分だ";
                textIndicate(sendStoryText);
                break;
            case "tukue":
                // タグが "Enemy" の場合の処理
                Debug.Log("つくえです");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "つくえだな";
                textIndicate(sendStoryText);
                break;
            case "kobinn":
                // タグが "Enemy" の場合の処理
                Debug.Log("小瓶がならんでいる");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "小瓶だ";
                textIndicate(sendStoryText);
                break;
            case "akari":
                // タグが "Enemy" の場合の処理
                Debug.Log("あかりだ");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "あかりがともっている";
                textIndicate2(sendStoryText);
                break;
            case "kusuribin":
                // タグが "kusuribin" の場合の処理
                Debug.Log("薬瓶だ");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "薬瓶だ。ん？これは？あやしい包み紙";
                getMoneyIndicate1(sendStoryText);
                break;
            case "fusuma":
                // タグが "Enemy" の場合の処理
                Debug.Log("ふすまだ");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "ふすまだ";
                textIndicate2(sendStoryText);
                break;
            case "tinoato":
                // タグが "Enemy" の場合の処理
                Debug.Log("血のあとだ");
                // ここにエネミーに関連する処理を記述します
                sendStoryText = "血のがここまで飛んでいる";
                textIndicate2(sendStoryText);
                break;
            default:
                // その他のタグの場合の処理
                Debug.Log("なにもないところだ");
                // ここにその他のオブジェクトに関連する処理を記述します
                break;
        }
    }

    void textIndicate(string _storyText)//テキスト出力用SelectGame1
    {
        Clicks.SetActive(false);
        objCharacterName.SetActive(true);
        objTextWindow.SetActive(true);
        storyText.text = _storyText;
        characterName.text = "市九郎";
        selectGame.onGame = false;
    }
    void textIndicate2(string _storyText)//テキスト出力用SelectGame2
    {
        Clicks.SetActive(false);
        objCharacterName.SetActive(true);
        objTextWindow.SetActive(true);
        storyText.text = _storyText;
        characterName.text = "市九郎";
        selectGame2.onGame2 = false;
    }
    void getMoneyIndicate1(string _storyText)//テキスト出力用SelectGame2
    {
        Clicks.SetActive(false);
        objCharacterName.SetActive(true);
        objTextWindow.SetActive(true);
        koban.SetActive(true) ;
        storyText.text = "小判を手に入れた。これだけでは足しになるまいが";
        characterName.text = "市九郎";
        selectGame2.getMoney = true;//trueにすると、エンディングへ。
        selectGame2.onGame2 = false;
    }
    
}