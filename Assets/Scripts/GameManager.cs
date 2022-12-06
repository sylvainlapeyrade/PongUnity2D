using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject ball;

    public GameObject player1;
    public GameObject player2;

    public GameObject goalPlayer1;
    public GameObject goalPlayer2;

    public GameObject scorePlayer1;
    public GameObject scorePlayer2;

    private int player1Score;
    private int player2Score;


    public void Player1Score()
    {
        player1Score++;
        scorePlayer1.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        Reset();
    }


    public void Player2Score()
    {
        player2Score++;
        scorePlayer2.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        Reset();
    }

    private void Reset()
    {
        ball.GetComponent<Ball>().ResetPosition();
        player1.GetComponent<Paddle>().ResetPosition();
        player2.GetComponent<Paddle>().ResetPosition();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Menu");
    }
}
