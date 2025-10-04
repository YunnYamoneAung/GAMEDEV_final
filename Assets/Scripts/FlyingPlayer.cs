using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyingPlayer : MonoBehaviour
{
    public float jumpForce = 5f;
    Rigidbody2D rb;
    void Awake() { rb = GetComponent<Rigidbody2D>(); }
    void Update() { if (Input.GetKeyDown(KeyCode.Space)) rb.linearVelocity = Vector2.up * jumpForce; }
    void OnCollisionEnter2D(Collision2D _) => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}