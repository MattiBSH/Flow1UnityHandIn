using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObstacleSpawner : MonoBehaviour
{
   float x;
   float z;
   float y = 63;
 bool DoSpawnRocks=true;
  public GameObject obstacle;
  public GameObject spawn;

private float time = 0.0f;
 public float interpolationPeriod = 0.1f;

 private void Start() {
       

         

 }

 private void Update() {
     
    time += Time.deltaTime;
 
     if (time >= interpolationPeriod) {
         time = 0.0f;
 
           //make Random x y
           
    x = Random.Range(222, 323);
    z = Random.Range(200, 280);

    //put spawn in random position
     spawn.transform.position=new Vector3(x, y, z);
    Debug.Log(x);
    //todo spawn object
    Instantiate(obstacle,spawn.transform.position,Quaternion.identity);

     }
    

 
 }

 
}
