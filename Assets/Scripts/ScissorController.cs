using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorController : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Scissor")
        {
            Destroy(gameObject);
        }
        
    }



    void OnCollisionEnter2D(Collision2D c)
    {
        Vector2 direction = c.GetContact(0).normal;
      if( direction.x == 1 )
      {
        print("left");
         transform.position += new Vector3(1, 0, 0);

      } 
     

      if( direction.x == -1 )
      {
        print("right");
        transform.position += new Vector3(-1, 0, 0);
      }
      if( direction.y == 1 )
      {
        print("down");
        transform.position += new Vector3(0, 1, 0);
      } 
       if( direction.y == -1 )
      {
        print("up");
        transform.position += new Vector3(0, -1, 0);
      } 
    }

    

}
