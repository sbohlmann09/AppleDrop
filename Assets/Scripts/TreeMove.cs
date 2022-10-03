using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
   public float speed;
    public float jumpHeight;
    public bool treeDir = false; 
    // Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // this.SetActive(true);
        // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        float moveDir = Input.GetAxis("Horizontal");

        // rb.velocity = new Vector2(moveDir * speed, rb.velocity.y);

        //Jump code
        

        //left wall -9.2
        if(!treeDir){
            pos.x -= speed * Time.deltaTime;
            if(pos.x <= -9.2){
            treeDir = true;
            }
            // Console.WriteLine("left");
        }
        //right wall 9.2
        if(treeDir ){
            pos.x += speed * Time.deltaTime;
            if(pos.x >= 9.2){
            treeDir = false;
            }
        }

        
        // if(Input.GetMouseButton(0))
        // {
        //     pos.x = Random.Range(-4.0F,4.0F);
        //     pos.y = Random.Range(-2.0F,2.0F);
        // }
        
        transform.position = pos;
    }
    // public void TurnOff(){
    //     this.SetActive(false);
    // }
}
