using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectGame : MonoBehaviour
{
    //セレクトゲーム用のスクリプトです
    [SerializeField] private Image background;
    [SerializeField] private TextMeshProUGUI storyText;
    [SerializeField] private TextMeshProUGUI characterName;

    public GameObject CharacterName;
    public GameObject TextWindow;
    public GameObject Clicks;

    public bool onGame = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !onGame) // 左クリック時ゲーム開始
        {
            CharacterName.SetActive(false);
            TextWindow.SetActive(false);
            Clicks.SetActive(true);
            onGame = true;
        }
    }
}
