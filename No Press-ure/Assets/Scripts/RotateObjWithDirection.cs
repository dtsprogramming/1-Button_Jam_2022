using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjWithDirection : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 5f;
    [SerializeField] private bool counterclockwiseRotation = false;

    private Transform _tf;

    // Start is called before the first frame update
    void Start()
    {
        _tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (counterclockwiseRotation)
        {
            _tf.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
        }
        else
        {
            _tf.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
        }
    }
}
