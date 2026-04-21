using System.Collections;
using System.Security.Cryptography;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{

    public GameObject cloud;
    public float offset;
    
    public int rate;
    public float timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if(timer < rate)
        {//will this change
            timer += Time.deltaTime;
        }
        else
        {
            spawncloud();
            timer = 0;
        }

    }

   void spawncloud()
    {
        float lowestpoint = transform.position.y - offset;
        float higestpoint = transform.position.y + offset;       
        
        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestpoint, higestpoint), Random.Range(-4, 4)), transform.rotation);
       

    }

   

}
