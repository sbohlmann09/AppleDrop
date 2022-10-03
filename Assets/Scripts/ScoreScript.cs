using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
   
    public Text ScoreText;
    public Text LivesText;
    public int score= 0;
    public int lives= 0;
    GameObject liv;
    GameObject sco;
 
 
    // Use this for initialization
    void Start () {
        liv = GameObject.Find("LivesText");
        sco = GameObject.Find("ScoreText");
        liv.SetActive(false);
        sco.SetActive(true);
        ScoreText.text = "Score: ";
        LivesText.text = "";
    }
 
 
    // Update is called once per frame
    void Update () {
   
        ScoreText.text = "Score: " + score;
        LivesText.text = "Game Over\nScore: " + score;
        if(lives <= 0)
        {
            liv.SetActive(true);
            sco.SetActive(false);
        }
    }
 
 
    public void AddPoint() {
        score = score + 1;
    }

    public void SubLife(){
        lives -= 1;
    }
    
 
}
 