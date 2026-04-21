using UnityEngine;

public class MIddlePipeScript : MonoBehaviour
{
   private LogicManagerScript Logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();    
    }

    // Update is called once per frame
    void Update() { }

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            Logic.score(1);
        }
    }

}
