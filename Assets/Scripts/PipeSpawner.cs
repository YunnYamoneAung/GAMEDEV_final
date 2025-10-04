using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float every = 1.6f;
    public float yRange = 2.2f;
    float t;
    void Update()
    {
        t += Time.deltaTime;
        if (t >= every)
        {
            t = 0;
            var p = Instantiate(pipePrefab, transform.position + Vector3.up * Random.Range(-yRange, yRange), Quaternion.identity);
        }
    }
}