using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = 2;
    private float timer = 0;
    public float heightOffSet = 10;
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Pipe, transform.position, transform.rotation);
        Instantiate(ps, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < SpawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffSet;
        float HighestPoint = transform.position.y + heightOffSet;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, HighestPoint), 0), transform.rotation);
    }
}
