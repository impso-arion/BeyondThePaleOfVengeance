using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Data", menuName ="StoryData")]
public class StoryData : ScriptableObject
{
    public List<Story> stories = new List<Story>();
    //�ǂ̉��y�𗬂���
    public SoundManager.BGM bgm;
}
[System.Serializable]
public class Story
{
    public Sprite Background;
    public Sprite CharacterImage;
    [TextArea]
    public string StoryText;
    public string CharacterName;

}