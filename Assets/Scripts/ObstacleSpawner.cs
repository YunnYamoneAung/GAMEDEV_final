using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnEvery = 1.2f;
    public float laneOffset = 3f;
    float t;

    void Update()
    {
        t += Time.deltaTime;
        if (t >= spawnEvery)
        {
            t = 0f;
            float lane = Random.Range(-1, 2); // -1,0,1
            Vector3 pos = new Vector3(lane * laneOffset, 0.5f, transform.position.z);
            var o = Instantiate(obstaclePrefab, pos, Quaternion.identity);
            Destroy(o, 10f);
        }
    }
}