using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    Vector3 pos;
    public float yy;
    public float timeToSpawn;
    private float currentTimeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        // this.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.y = pos.y - yy;
        if(currentTimeToSpawn > 0){
            currentTimeToSpawn -= Time.deltaTime;

        }
        else{
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
            

        }
    }

    public void SpawnObject(){
        
        Instantiate(objectToSpawn, pos, transform.rotation);
    }
    // public void TurnOff(){
    //     this.SetActive(false);
    // }
}
