using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{   public ScoreScript script;
    GameObject tree;
    // public GameObject spaw = ;
    // ScoreScript script;

    void Start(){
        tree = GameObject.Find("Tree");
        tree.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other){
        // Debug.Log(other.name);
        // other.gameObject.SetActive(false);
        if(other.name == "Ground"){
            // Debug.Log("Ground Hit");
            script.SubLife();
            Destroy(this.gameObject);
            if(script.lives == 2)
                Destroy(GameObject.Find("Bucket"));
            else if(script.lives == 1)
                Destroy(GameObject.Find("Bucket (1)"));
            else {
                Destroy(GameObject.Find("Bucket (2)"));
                tree.SetActive(false);
                // spaw.TurnOff();
            }
        }
        else{
            script.AddPoint();
            Debug.Log(script.score);
            Destroy(this.gameObject);
        }
        //Debug.Log("Hit detected!");
    }


    void Update(){
    }
}
