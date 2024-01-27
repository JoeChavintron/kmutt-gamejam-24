using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineController : MonoBehaviour
{
    [field: SerializeField]
    private float minDistance = 0.1f;

    [field: SerializeField]
    private GameObject player;

    [field: SerializeField]
    public GameObject prefab;

    private LineRenderer line;
    private Vector3 previousPosition;

    // Start is called before the first frame update
    private void Start()
    {
        line = GetComponent<LineRenderer>();
        createEndOfObject();
        previousPosition = player.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        drawLine();
    }

    void drawLine() {
        Vector3 currentPosition = player.transform.position;
        
        if (Vector3.Distance(currentPosition, previousPosition) > minDistance) {
            
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, currentPosition);
        }
    }

    void createEndOfObject() {
        Instantiate(prefab, player.transform.position, Quaternion.identity);
    }
}
