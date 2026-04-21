using System;
using UnityEngine;
using UnityEngine.UI;

public class MovePipeScript : MonoBehaviour
{
    public float MoveSpeed = 3;
    public float deadend = -55;
    public Boolean ispause = false;
    public LogicManagerScript Logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += (MoveSpeed * Vector3.left) * Time.deltaTime;

        if (transform.position.x < deadend)
        {
            //Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
     
    }
}

