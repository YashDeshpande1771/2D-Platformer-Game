using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{
    protected Vector2 velocity;
    protected Rigidbody2D rb2d;
    public float gravityModifier = 1f;    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        velocity += gravityModifier * Physics2D.gravity * Time.deltaTime;
        Vector2 deltaPosition = velocity * Time.deltaTime;
        Vector2 move = Vector2.up * deltaPosition.y;
        movement(move);

    }
    void OnEnable()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void movement(Vector2 move)
    {
        rb2d.position = rb2d.position + move;
    }
}