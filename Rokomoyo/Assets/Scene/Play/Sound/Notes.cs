using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Notes : MonoBehaviour
{

    /// <summary>
    /// 曲のタイプ
    /// </summary>
    public enum MusicType
    {
        // 無音
        NONE,
        // 近づける音
        ATTRACT,
        // 遠ざける音
        AWAY,
    };

    // 音の種類
    public MusicType type = MusicType.NONE;
    // 管理者を記憶
    SoundManager soundManager = null;

    // 曲情報
    private MusicList.MusicData soundData;

    public MusicList.MusicData SoundData
    {
        // 取得
        get
        {
            return soundData;
        }
    }

    CharacterManager charaManager;

    /// <summary>
    /// 音符の初期化
    /// </summary>
    void InitNotes()
    {
        // 管理者のオブジェクトを探す
        GameObject obj = GameObject.Find("SoundManager");
        // PlayManagerのコンポーネントを取得
        soundManager = obj.GetComponent<SoundManager>();
        // 曲情報の取得
        soundData = soundManager.GetMusic(type);
    }

    /// <summary>
    /// 音符がクリックされた時の処理
    /// </summary>
    /// <param name="data">クリックイベント</param>
    public void ClickNotes(BaseEventData data)
    {
        charaManager.SetNotes(this.gameObject.GetComponent<Notes>());
        Debug.Log("くりっくされたぉ～。V（・~・）V");
        // 音を再生させる
        if(soundManager.ChangeMusic(type, soundData))
        {
            soundManager.PlayMusic();
        }
        else
        {
            soundManager.StopMusic();
        }
    }


    private void Awake()
    {
        GameObject obj =  GameObject.Find("CharacterManager");
        charaManager = obj.gameObject.GetComponent<CharacterManager>();
    }

    /// <summary>
    /// Use this for initialization
    /// </summary>
    private void Start ()
    {
        InitNotes();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    private void Update ()
    {
    }
}
