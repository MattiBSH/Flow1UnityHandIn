 using UnityEngine;
 using System.Collections;
 
 public class Respawn : MonoBehaviour {
 
     public GameObject spawnPoint;
   
    private void OnCollisionEnter(Collision other) {
         if(other.transform.tag == "Obstacle")
         {
              this.transform.position = spawnPoint.transform.position;
         }
    }
     
 }