using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float lateralSpeed = 6f;
    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * h * lateralSpeed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.collider.CompareTag("Obstacle"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}