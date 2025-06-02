using UnityEngine;

public class LineConnector : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public LineRenderer line;

    void Start()
    {
        line.positionCount = 2;
    }

    void Update()
    {
        line.SetPosition(0, pointA.position);
        line.SetPosition(1, pointB.position);
    }
}