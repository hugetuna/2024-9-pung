using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int p1Score=0;
    public int p2Score=0;
    public Text p1ScoreText;
    public Text p2ScoreText;
    public Text winerText;

    public GameObject server;
    public GameObject gameOverScreen;
    [ContextMenu("p1Plus")]
    public void p1AddScore(int point)
    {
        p1Score = p1Score + point;
        p1ScoreText.text = p1Score.ToString();
        if (p1Score == 10)
        {
            endGame("p1");
        }
        else
        {
            server.GetComponent<serverScript>().serverBall();
        }
        
    }
    [ContextMenu("p2Plus")]
    public void p2AddScore(int point)
    {
        p2Score = p2Score + point;
        p2ScoreText.text = p2Score.ToString();
        if (p2Score == 10)
        {
            endGame("p2");
        }
        else
        {
            server.GetComponent<serverScript>().serverBall();
        }
    }
    [ContextMenu("show end")]
    public void endGame(string winer)
    {
        winerText.text = "winer is "+ winer;
        gameOverScreen.SetActive(true);
    }
    // load
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
