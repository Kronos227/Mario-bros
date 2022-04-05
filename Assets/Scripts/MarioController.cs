using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioController : MonoBehaviour
{
    
    public float speed = 5.0f;
    public float jumpforce;
    private float horizontal;

    public Rigidbody2D m_rigidBody;


    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_rigidBody.velocity = new Vector2(m_rigidBody.velocity.x, jumpforce);
            print("Space key was pressed");
        }

    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        m_rigidBody.velocity = new Vector2(horizontal * speed, m_rigidBody.velocity.y);
    }
   

}
