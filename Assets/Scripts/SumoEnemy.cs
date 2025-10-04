using UnityEngine;
public class SumoEnemy : MonoBehaviour
{
    public Transform player;
    public float force = 12f;
    Rigidbody rb;
    void Awake(){ rb = GetComponent<Rigidbody>(); }
    void FixedUpdate()
    {
        Vector3 dir = (player.position - transform.position).normalized;
        rb.AddForce(new Vector3(dir.x, 0, dir.z) * force);
    }
}