using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text scoreText;
    public int score;
    // Use this for initialization

    void Start () {
        score = 0;
        UpdateScore();
    }
	
	// Update is called once per frame
	void Update () {
        UpdateScore();

    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    public void UpdateScreen()
    {
        scoreText.text = "Wait !! ";
    }


}
