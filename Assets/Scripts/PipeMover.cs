using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float speed = 2.5f;
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x < -12f) Destroy(gameObject);
    }
}