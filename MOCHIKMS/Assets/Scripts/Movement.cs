using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private int moveDirection;
    [SerializeField]
    private GameObject mochi;
    private GameObject food;
    private float speed = 1.0f;

    private void Awake()
    {
        InvokeRepeating("RandomNumber", 2.0f, 2.0f);
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        food = GameObject.FindGameObjectWithTag("Spawnable");

        if (food == null)
        {
            if (rb.velocity == new Vector2(0, 0))
            {
                if (moveDirection == 1)
                {
                    rb.velocity = Vector2.zero;
                }
                else if (moveDirection == 3)
                {
                    rb.velocity = Vector2.right;

                }
                else if (moveDirection == 2)
                {
                    rb.velocity = Vector2.left;
                }
            }
        }
        else
        {
            mochi.transform.position = Vector3.MoveTowards(mochi.transform.position, food.transform.position, Time.deltaTime * speed);
        }
        
    }

    void RandomNumber()
    {
       moveDirection = Random.Range(1, 4);
      GetComponent<Animator>().SetInteger("direction", moveDirection);
    }
    
}
