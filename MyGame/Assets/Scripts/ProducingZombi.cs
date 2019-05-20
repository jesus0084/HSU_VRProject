using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducingZombi : MonoBehaviour
{
    public GameObject zombi;
    public float startHeight = 2.0f;
    public float makeInterval = 1.0f;
    private float nextZombi = 0.0f;

    
    void Start()
    {
        makeInterval = 1.0f;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextZombi)
        {
            nextZombi = Time.time + makeInterval;
            Vector3 position = new Vector3(Random.Range (-50.0f, 50.0f), startHeight, Random.Range (-50.0f, 50.0f));
            Instantiate(zombi, position, Quaternion.identity);
        }

        /*
        else if (Time.time > 30.0f)
        {
            makeInterval = 0.6f;
            nextZombi = Time.time + makeInterval;
            Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), startHeight, Random.Range(-50.0f, 50.0f));
            Instantiate(zombi, position, Quaternion.identity);
        }
        else if (Time.time > 60.0f)
        {
            makeInterval = 0.4f;
            nextZombi = Time.time + makeInterval;
            Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), startHeight, Random.Range(-50.0f, 50.0f));
            Instantiate(zombi, position, Quaternion.identity);
        }
        else if (Time.time > 90.0f)
        {
            makeInterval = 0.09f;
            nextZombi = Time.time + makeInterval;
            Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), startHeight, Random.Range(-50.0f, 50.0f));
            Instantiate(zombi, position, Quaternion.identity);
        }
        else if (Time.time > 120.0f)
        {
            makeInterval = 0.05f;
            nextZombi = Time.time + makeInterval;
            Vector3 position = new Vector3(Random.Range(-50.0f, 50.0f), startHeight, Random.Range(-50.0f, 50.0f));
            Instantiate(zombi, position, Quaternion.identity);
        }
        */

    }
}
