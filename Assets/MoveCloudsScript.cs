using UnityEngine;

public class MoveCloudsScript : MonoBehaviour  
    
{
  
    public float higestspeed;
    public float lowestspeed;  
    public float speed;
    public float deadend;
    public LogicManagerScript Logic;

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        //Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
        speed = Random.Range(lowestspeed, higestspeed);
    }

    // Update is called once per frame
    void Update()
    {

        transform.position += (speed * Vector3.left) * Time.deltaTime;

        if (transform.position.x < deadend)
        {
            //Debug.Log("cloud deleted");
            Destroy(gameObject);
        }


    }
}
