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
  public GameObject player;
  private float time = 0.0f;

 private void Start() {  
 }

 private void Update() {
     //Matti Script
    time += Time.deltaTime;
    float heightOfPlayer =player.transform.position.y;
    //adjusting for height to mak difficulty higher when getting close to goal
     if (time >= (0.4-((heightOfPlayer/10)/31))) {
       time = 0.0f;
    //make Random x z y 
    x = Random.Range(252, 333); z = Random.Range(235, 286); y = Random.Range(69, 75); 
    //variable for deployment of specific object
    t = Random.Range(1,3);
    //put spawn in random position
     spawn.transform.position=new Vector3(x, y, z);
    //spawning object
    if (t>1.1)
    {
      Instantiate(obstacle2,spawn.transform.position,Quaternion.identity);
    } else
    {
      Instantiate(obstacle,spawn.transform.position,Quaternion.identity);
    }
    } 
 }

 
}
