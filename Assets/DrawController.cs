using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawController : MonoBehaviour
{
    [SerializeField]
    private float minDistance = 0.1f;
    [SerializeField]
    public Vector3 currentPosition;

    private LineRenderer line;
    private Vector3 previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(currentPosition, previousPosition) > minDistance) {
            line.positionCount++;
            line.SetPosition(line.positionCount - 1, currentPosition);
        }
    }
}
