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
                // タグが "Player" の場合の処理
                Debug.Log("押し入れ２です");
                // ここにプレイヤーに関連する処理を記述します
                break;
            case "osiire":
                // タグが "Enemy" の場合の処理
                Debug.Log("押し入れです");
                // ここにエネミーに関連する処理を記述します
                break;
            default:
                // その他のタグの場合の処理
                Debug.Log("その他のオブジェクトです");
                // ここにその他のオブジェクトに関連する処理を記述します
                break;
        }
    }
}