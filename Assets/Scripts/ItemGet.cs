using UnityEngine;

public class ItemGet : MonoBehaviour
{
    /// <summary>アイテムを取った時に鳴る効果音</summary>
    [Tooltip("アイテムを取った時に鳴らす効果音")]
    [SerializeField] AudioClip _sound = default;
    bool isGet;             // 獲得済みフラグ

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("げっと");
            if (_sound)
            {
                AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
            }
            Score.tempCoinNum++;//Playerが接触した場合加算する＝＞これによりScoreスクリプトにも反映できる
            // プレイヤーが接触で獲得判定
            if (!isGet)
            {
                isGet = true;
            }
            Destroy(gameObject);

        }

    }
}
