using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        Launch(); 
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rigidBody2D.velocity = new Vector2(speed * x, speed * y);
    }
    
}
