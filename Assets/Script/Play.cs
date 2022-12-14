using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    Rigidbody2D rigid2D;         
    float jumpForce = 680.0f;     
    float walkForce = 30.0f;      
    float maxWalkSpeed = 2.0f;    

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }

        
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

    }
}
