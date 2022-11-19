// coded by eddy :)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayaMovement : MonoBehaviour
{
    public float speed;
    private float Move;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
    }
}
