using System;
using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength;
    public LogicManagerScript Logic;
    public Boolean alive = true;
     [SerializeField] public float YBoundary_Up;
    [SerializeField] public float YBoundary_Down;
    //public AudioSource BirdFlap;
    
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody.linearVelocity = Vector2.up * FlapStrength;
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (alive == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
            {
                //BirdFlap.Play();
                myRigidbody.linearVelocity = Vector2.up * FlapStrength;
                
            }
            if (gameObject.transform.position.y >= YBoundary_Up || gameObject.transform.position.y <= YBoundary_Down)
            {
                Logic.gameover();
                alive = false;
                
            }
        }

    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameover();
        alive = false;
        Time.timeScale = 0;
       
    }   



}


