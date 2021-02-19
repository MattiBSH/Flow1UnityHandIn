using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningScript : MonoBehaviour
{

    public GameObject winText;
    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void OnTriggerEnter(Collider collider)
    {
      if(collider.gameObject.name == "shadow"){
        Debug.Log($"{collider.gameObject.name} just entered the trigger of {gameObject.name}");
        winText.SetActive(true);
        lose.SetActive(false);
        collider.gameObject.transform.position = new Vector3(251.79f, 2.36f, 149.8f);
      }
    }
}