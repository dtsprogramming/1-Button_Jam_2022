using UnityEngine;

public class GameObjShredder : MonoBehaviour
{
    private GameObject obj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        obj = collision.gameObject;
        Destroy(obj);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        obj = collision.gameObject;
        Destroy(obj);
    }
}
