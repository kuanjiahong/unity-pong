using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    public TMPro.TMP_Text playerScoreText;
    public TMPro.TMP_Text computerScoreText;

    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }
    
    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    
}
