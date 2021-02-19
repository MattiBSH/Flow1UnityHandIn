using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObstacleSpawner2 : MonoBehaviour
{
  float x; float z; float y; float t;

  public GameObject obstacle;
  public GameObject obstacle2;
  public GameObject spawn;
  public GameObject spawn2;
  private float time = 0.0f;

 private void Start() {  
 }

 private void Update() {
     
    time += Time.deltaTime;
 
     if (time >= 0.1) {
       time = 0.0f;
    //make Random x y 
    x = Random.Range(222, 340);
    z = Random.Range(200, 290);
    y = Random.Range(60, 62);
    t = Random.Range(1,3);
    //put spawn in random position
     spawn.transform.position=new Vector3(x, y, z);
    Debug.Log(x);
    //todo spawn object2
    if (t>1.1)
    {
      Instantiate(obstacle2,spawn.transform.position,Quaternion.identity);

    }else
    {
      Instantiate(obstacle,spawn.transform.position,Quaternion.identity);

    }

     }
//make work with 2 objects
    /*  if (time >= 2.9) {
         
           //make Random x y
    x = Random.Range(222, 323);
    z = Random.Range(200, 280);
    y = Random.Range(55, 62);
    //put spawn in random position
     spawn.transform.position=new Vector3(x, y, z);
    Debug.Log(x);
    //todo spawn object1
    Instantiate(obstacle,spawn.transform.position,Quaternion.identity);
     } */

    
    

   
 
 }

 
}
