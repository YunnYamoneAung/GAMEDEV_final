using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float speed = 12f;
    void Update() => transform.Translate(Vector3.back * speed * Time.deltaTime);
}