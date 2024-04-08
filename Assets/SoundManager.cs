using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource bgmAudiosource = default;
    [SerializeField] private AudioClip[] bgmClips;

    public enum BGM//BGM�̔z���񋓌^�ō���Ă���
    {
        battle,
        escape,
        Title
    }


    public void PlayBGM(BGM bgm)
    {
        if(bgmAudiosource.clip != bgmClips[(int)bgm])
        {
            bgmAudiosource.clip = bgmClips[(int)bgm];
            bgmAudiosource.Play();
        }
    }
}
