using UnityEngine;

/// <summary>
/// アイテムを制御する基底クラス
/// アイテムの共通機能を実装する
/// </summary>
public class ItemManager : MonoBehaviour
{
    public Transform parentTran;
    public GameObject _item;

    //等間隔でアイテムを表示させる
    private void Start()
    {
        CreateBlockObject();
    }
    private void Update()
    {

    }


    void CreateBlockObject()
    {
        int row = 18;
        int column = 1;
        float xOffset = 1f;//X軸の間隔
        float zOffset = 5f;//Z軸の間隔

        for (int j = 0; j < row; j++)
        {
            for (int i = 0; i < column; i++)
            {
                // ゲームオブジェクトを生成します。
                GameObject obj = Instantiate(_item, Vector3.zero, Quaternion.identity);

                // ゲームオブジェクトの親オブジェクトを設定します。
                obj.transform.SetParent(parentTran);

                // ゲームオブジェクトの位置を設定します。
                float xPos = xOffset * i;
                float zPos = zOffset * j;
                obj.transform.localPosition = new Vector3(xPos, 0.5f, zPos);
            }
        }
    }
}
