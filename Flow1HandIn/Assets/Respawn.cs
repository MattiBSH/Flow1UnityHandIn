 using UnityEngine;
 using System.Collections;
 
 public class Respawn : MonoBehaviour {
 
     public GameObject spawnPoint;
     public GameObject win;
     public GameObject lose;
   
    private void OnCollisionEnter(Collision other) {
         if(other.transform.tag == "Obstacle")
         {
              this.transform.position = spawnPoint.transform.position;
               win.SetActive(false);
               lose.SetActive(true);
               /* GameObject[] enemies = GameObject. FindGameObjectsWithTag(tag);
               for(int i=0; i< enemies. Length; i++)
               {
               Destroy(enemies[i]);
               } */
         }
         if(other.transform.tag == "Obstacle2")
         {
              this.transform.position = spawnPoint.transform.position;
               win.SetActive(false);
               lose.SetActive(true);
              
         }
    }
     
 }