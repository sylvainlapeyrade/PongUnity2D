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
    public bool isAI;

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

        // Left Paddle AI is activated if the bool is true in the inspector or if the menu is set to 1 or 0 player
        if ((isAI || MenuController.nbPlayer < 2) && isPlayer1 && GameObject.Find("Ball").GetComponent<Ball>().rigidBody2D.velocity.x < 0)
            MoveTowardBallY();

        // Right Paddle AI is activated if the bool is true in the inspector or if the menu is set to 0 player
        if ((isAI || MenuController.nbPlayer == 0) && !isPlayer1 && GameObject.Find("Ball").GetComponent<Ball>().rigidBody2D.velocity.x > 0)
            MoveTowardBallY();

        rigidBody2D.velocity = new Vector2(0, movement) * speed;
    }

    private void MoveTowardBallY()
    {
        float coordYball = GameObject.Find("Ball").transform.position.y;
        transform.position = new Vector3(transform.position.x, coordYball, transform.position.z);
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        rigidBody2D.velocity = Vector2.zero;
    }
}
