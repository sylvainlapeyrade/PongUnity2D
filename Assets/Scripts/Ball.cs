using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public float initSpeed;
    public Rigidbody2D rigidBody2D;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Launch();
    }

    public void ResetPosition()
    {
        speed = initSpeed;
        transform.position = startPosition;
        rigidBody2D.velocity = Vector2.zero;
        Launch();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "GoalPlayer1")
        {
            Debug.Log("Player 1 scored!");
            GameObject.Find("GameManager").GetComponent<GameManager>().Player1Score();
        }
        else if (collision.gameObject.name == "GoalPlayer2")
        {
            Debug.Log("Player 2 scored!");
            GameObject.Find("GameManager").GetComponent<GameManager>().Player2Score();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
            speed += 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        rigidBody2D.velocity = rigidBody2D.velocity.normalized * speed;
    }
    
    private void Launch()
    {
        initSpeed = speed;

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rigidBody2D.velocity = new Vector2(speed * x, speed * y);
    }
    
}
