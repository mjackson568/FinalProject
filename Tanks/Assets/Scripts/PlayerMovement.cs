using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;
    public GameObject Tank;
    // Start is called before the first frame update
    void Start()
    {
        Tank.transform.position = new Vector3(0.5f, 0f, 0f);
        xAngle = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Tank.transform.Rotate(xAngle, yAngle, zAngle);
    }
}
