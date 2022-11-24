using UnityEngine;

public class MoveObjWithVelocity : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 20f;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + new Vector2(-moveSpeed, 0f) * Time.deltaTime);
    }
}
