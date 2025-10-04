using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class SumoPlayer : MonoBehaviour
{
    public float moveForce = 15f;
    Rigidbody rb;
    void Awake(){ rb = GetComponent<Rigidbody>(); }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(new Vector3(h, 0, v) * moveForce);
        if (transform.position.y < -1f) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}