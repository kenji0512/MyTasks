using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    //レーンの設定
    const int MinLane = -2;
    const int MaxLane = 2;
    const float LaneWidth = 1.0f;

    Rigidbody _rb;
    float _h;
    float _v;

    // スピード
    public float _speedX = 1.0f;
    public float _speedZ = 10f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Goal"))
        {
            _speedZ = 0;
            _rb.Sleep();
            //Destroy(_rb);
        }
    }

    void Update()
    {
        //X軸の動きの処理
        Vector3 dir = new Vector3(_h, 0, _v);
        _h = Input.GetAxisRaw("Horizontal");
        dir.y = 0;
        _rb.velocity = dir * _speedX;

        //Vector3 dirV = new Vector3(0, 0, _v);
        _rb.velocity = -dir * _speedX;
        _rb.AddForce(transform.forward * _speedZ);


    }
}
