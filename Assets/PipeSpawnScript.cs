using System.Threading;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour {

    public GameObject pipe;
  
    public float Timer;
    public float SpwanRate= 2;
    public float heightoffset = 10;


 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Timer < SpwanRate)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            Timer = 0;
        }

       
    

    }

    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highestpoint), 0), transform.rotation);

        


    }
}
