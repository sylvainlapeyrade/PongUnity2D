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

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical1");
        }
        else
        {
            movement = Input.GetAxis("Vertical2");
        }

        rigidBody2D.velocity = new Vector2(0, movement) * speed;
    }
}
