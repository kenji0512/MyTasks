using UnityEngine;

/// <summary>
/// �A�C�e���𐧌䂷����N���X
/// �A�C�e���̋��ʋ@�\����������
/// </summary>
public class ItemManager : MonoBehaviour
{
    public Transform parentTran;
    public GameObject _item;

    //���Ԋu�ŃA�C�e����\��������
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
        float xOffset = 1f;//X���̊Ԋu
        float zOffset = 5f;//Z���̊Ԋu

        for (int j = 0; j < row; j++)
        {
            for (int i = 0; i < column; i++)
            {
                // �Q�[���I�u�W�F�N�g�𐶐����܂��B
                GameObject obj = Instantiate(_item, Vector3.zero, Quaternion.identity);

                // �Q�[���I�u�W�F�N�g�̐e�I�u�W�F�N�g��ݒ肵�܂��B
                obj.transform.SetParent(parentTran);

                // �Q�[���I�u�W�F�N�g�̈ʒu��ݒ肵�܂��B
                float xPos = xOffset * i;
                float zPos = zOffset * j;
                obj.transform.localPosition = new Vector3(xPos, 0.5f, zPos);
            }
        }
    }
}
