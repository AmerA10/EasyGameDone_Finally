using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTrail : MonoBehaviour
{
    public GameObject trail;
    public float spawnTrailTime = 0.50f;
    public float spawnTrailCD = 0f;


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= spawnTrailCD)
        {
            Instantiate(trail, this.transform.position, this.transform.rotation);
            spawnTrailCD = Time.time + spawnTrailTime;
        }
     
    }
}
