using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidBody2D;
    private float movement;
    public bool isPlayer1;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical");
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
        }

        rigidBody2D.velocity = new Vector2(0, movement) * speed;
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        rigidBody2D.velocity = Vector2.zero;
    }
}
