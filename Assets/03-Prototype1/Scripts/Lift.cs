using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    Vector3 intiPos;

    private void Start()
    {
        intiPos = transform.position;
    }
    private void Update()
    {
        transform.position = new Vector3(intiPos.x, Mathf.Sin(Time.time) + intiPos.y, intiPos.z);
    }
}
