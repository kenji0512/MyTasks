using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //static Score _instance = new Score();
    //public static Score Instance => _instance;
    //private Score() { }
    //ゲームに一つだけどこからも参照できるが、最初から最後までいる存在、MonoBehaviourは継承しないで使う
    //ミタライさんメモ

    /// <summary>別のところからでも参照できるようにする</summary>
    public static int tempCoinNum;
    public Text Scoretext;

    //public void AddScore(int score)
    //{
    //    tempCoinNum += score;
    //}
    //public int GetScore ()
    //{
    //    return tempCoinNum;
    //}もう一つのやり方

    // Update is called once per frame
    void Update()
    {
        Scoretext.text = "Score:" + tempCoinNum;
    }
}
