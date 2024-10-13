using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle paddle;
    public TMP_Text scoreText;
    private int _score;
    private int _highScore;

    public TMP_Text livesText;
    private int _lives;

    public void BlockDestroyed(int blockScore){
        _score += blockScore;

        this.scoreText.text = _score.ToString("00000");
    }

    private void Start(){
        this._highScore = 0;
        this.NewGame();
    }

    private void NewGame(){
        this._score = 0;
        this.scoreText.text = _score.ToString("00000");
        this._lives = 3;
        this.livesText.text = _lives.ToString();
    }

    public void LostLife(){
        this._lives--;
        this.livesText.text = _lives.ToString();
        if (this._lives == 0){
            this.LoseGame();
        }
        else{
            this.ball.ResetPosition();
            this.paddle.ResetPosition();
            this.ball.AddStartingForce();
        }
    }

    public void LoseGame(){
        Time.timeScale = 0;
    }

    public void WinGame(){

    }
}
