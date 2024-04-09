using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectGame2 : MonoBehaviour
{
    //セレクトゲーム2用のスクリプトです
    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI storyText;
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private GameObject koban;
    public GameObject CharacterName;
    public GameObject TextWindow;
    public GameObject Clicks;

    public bool onGame2 = false;

    public bool getMoney = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !onGame2) // 左クリック時ゲーム開始
        {
            koban.SetActive(false);
            CharacterName.SetActive(false);
            TextWindow.SetActive(false);
            Clicks.SetActive(true);
            onGame2 = true;
        }
    }
}
