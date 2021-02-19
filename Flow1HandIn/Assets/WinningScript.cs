using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningScript : MonoBehaviour
{

    public GameObject winText;
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
        Debug.Log($"{collider.gameObject.name} just entered the trigger of {gameObject.name}");
        winText.SetActive(true);
        collider.gameObject.transform.position = new Vector3(251.79f, 2.36f, 149.8f);
    }
}