using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DunnyObjectController : MonoBehaviour
{   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Floor") {
            print("tag Floor");
        }
        print("---------");
        if (other.tag == "Player") {
            Debug.Log("taging");
        }
        print("---------");
        
    }
 
}
