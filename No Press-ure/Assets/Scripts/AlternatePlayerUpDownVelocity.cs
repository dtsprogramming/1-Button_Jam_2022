using UnityEngine;

public class AlternatePlayerUpDownVelocity : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 100f;

    private Rigidbody2D _rb;
    private bool isMovingUp;
    private bool[] randBool = {true, false};

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        isMovingUp = randBool[Random.Range(0, randBool.Length)];
    }

    private void FixedUpdate()
    {
        ChangeVelocity();
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isMovingUp = !isMovingUp;
        }
    }

    private void ChangeVelocity()
    {
        if (!isMovingUp)
        {
            _rb.velocity = new Vector2(0f, moveSpeed) * Time.deltaTime;
        }
        else
        {
            _rb.velocity = new Vector2(0f, -moveSpeed) * Time.deltaTime;
        }
    }
}
