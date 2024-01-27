using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DunnyObjectController : MonoBehaviour
{   
    private int tagFloorCount;

    [field: SerializeField]
    private GameObject floorObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Floor") {
            print("Tag Floor");
            floorObject = other.gameObject;
        }
        print("---------");
        if (other.tag == "Player") {
            Debug.Log("taging");
            tagFloorCount++;
            if (tagFloorCount >= 2) {
                print("delete");
                Destroy(floorObject.gameObject);
            }
        }
        print("---------");
        
    }
 
}
