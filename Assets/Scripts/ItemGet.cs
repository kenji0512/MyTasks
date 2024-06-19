using UnityEngine;

public class ItemGet : MonoBehaviour
{
    /// <summary>�A�C�e������������ɖ���ʉ�</summary>
    [Tooltip("�A�C�e������������ɖ炷���ʉ�")]
    [SerializeField] AudioClip _sound = default;
    bool isGet;             // �l���ς݃t���O

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("������");
            if (_sound)
            {
                AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
            }
            Score.tempCoinNum++;
            // �v���C���[���ڐG�Ŋl������
            if (!isGet)
            {
                isGet = true;
            }
            Destroy(gameObject);

        }

    }
}
