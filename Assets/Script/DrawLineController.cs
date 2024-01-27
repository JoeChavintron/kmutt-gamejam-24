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

    // Update is called once per frame
    public bool isDraw;


    public void StartDraw() {
        previousPosition = player.transform.position;
    }

    private void Update() {
        DrawLine();
    }

    public void DrawLine() {
        if (isDraw == false) {
            return;
        }
        line = GetComponent<LineRenderer>();
        // createEndOfObject();
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
