using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpawnerScript : MonoBehaviour
{
    public GameObject Spikes;
    public float spawnRate = 5;
    private float timer = 0;
    public float heightOffset = 3;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void FixedUpdate()
    {

        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else
        {
            spawnSpike();
            timer = 0;
        }
    }
    void spawnSpike()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Spikes, new Vector3( transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}