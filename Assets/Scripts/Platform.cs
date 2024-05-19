using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    BoxCollider platfromCollider;

    public void Awake()
    {
        platfromCollider = GetComponent<BoxCollider>();
    }
    public Vector3 ReturnEndPoint()
    {
        Vector3 calculatedEndPoint;
        calculatedEndPoint.x = platfromCollider.bounds.size.x + this.transform.position.x;
        calculatedEndPoint.y = 0;
        calculatedEndPoint.z = 0;
        return calculatedEndPoint;
    }
}
