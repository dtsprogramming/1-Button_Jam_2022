using UnityEngine;

public class PlayerWeaponRotation : MonoBehaviour
{
    private Transform tf;
    [SerializeField] private float rotateSpeed = 300f;

    private void Start()
    {
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        RotateWeapon();
    }

    private void RotateWeapon()
    {
        tf.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}
