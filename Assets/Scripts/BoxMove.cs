using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    
    // Rigidbody2D rb;
    public float yy;
    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 pos = transform.position;

        // float moveDir = Input.GetAxis("Mouse X");

        // rb.velocity = new Vector2(moveDir * speed, rb.velocity.y);

        //Jump code

       Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       Vector3 turnIn = mousePosition;
        turnIn.y = yy;
        turnIn.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        if(mousePosition.x <= -10)
        {
            turnIn.x = (float)-9.99;
        }
        else if(mousePosition.x >= 10)
        {
            turnIn.x = (float)9.99;
        }


        transform.position = turnIn;
        // pos.x = Input.mousePosition;
        
        // if(Input.mousePosition){
        //     pos.x == 
        // }
        // if(Input.GetKey("d")){
        //     pos.x += speed * Time.deltaTime;
        // }

        
        // if(Input.GetMouseButton(0))
        // {
        //     pos.x = Random.Range(-4.0F,4.0F);
        //     pos.y = Random.Range(-2.0F,2.0F);
        // }
        
        // transform.position = pos;
    }
}
