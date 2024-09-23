using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public TMP_Text scoreText;
    private int _score;

    private void Start(){
        this._score = 0;
        this.scoreText.text = _score.ToString("00000");
    }

    public void PlayerScores(){
        _score += 100;
        this.scoreText.text = _score.ToString("00000");
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void ResetGame() {
        _score = 0;
        this.scoreText.text = _score.ToString();
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.ball.AddStartingForce();
    }
}
