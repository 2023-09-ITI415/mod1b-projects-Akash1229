using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree_Script : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    tranform.position.X += speed* Time.deltaTime;

    pos.x += speed* Time.deltaTime;
    pos.x += 1.0f * 0.04f;
    pos.x += 0.04;

        public static float bottomY = -20f;
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if ( pos.x < -1eftAndRightEdge ) {
            speed = Mathf.Abs(speed);
        } else if ( pos.x > leftAndRightEdge ) {
            speed = -Mathf.Abs(speed);
        } else if ( Random.value < chanceToChangeDirections ) { 
            speed *= -1
        }
     
    }
}
