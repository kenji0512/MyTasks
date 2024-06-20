using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    Rigidbody _rb;
    float _h;

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
        }
    }

    void Update()
    {
        //X軸の動きの処理
        Vector3 dir = new Vector3(_h, 0, 0);
        _h = Input.GetAxisRaw("Horizontal");
        dir.y = 0;
        _rb.velocity = dir * _speedX;

        //Z軸の動きの処理
        _rb.AddForce(transform.forward * _speedZ);

        if (transform.position.x < -5) transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        if (transform.position.x > 5) transform.position = new Vector3(5, transform.position.y, transform.position.z);
    }
}
