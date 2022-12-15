using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Animator anim;

    public float moveSpeed = 5f;
    public Transform movePoint;
    public AudioSource audioPlayer;


    public LayerMask whatStopsMovement;
    void start()
    {
        movePoint.parent = null;
    }

    private void Awake() 
    {
        anim = GetComponent<Animator>();
    }



    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
        {
            if (Mathf.Abs(horizontalInput) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(horizontalInput, 0f, 0f), .2f, whatStopsMovement))
                {
                    audioPlayer.Play();
                    movePoint.position += new Vector3(horizontalInput, 0f, 0f);
                }

            } else if (Mathf.Abs(verticalInput) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, verticalInput, 0f), .2f, whatStopsMovement))
                {
                    audioPlayer.Play();
                    movePoint.position += new Vector3(0f, verticalInput, 0f);
                }

            }
        }
        if (horizontalInput > 0.01f)
        {
            transform.localScale = new Vector3(-2.5f, 2.5f, 2f);
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(2.5f,2.5f,2f);
        }

        anim.SetBool("run", horizontalInput != 0);

    }

    



  
}
