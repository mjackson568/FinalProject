using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 3.0f;
    public float rotationSpeed = 90.0f;
    //public float xAngle, yAngle, zAngle;
    //public GameObject Tank;
     //Start is called before the first frame update
    void Start()
    {
        //Updated upstream
        //Tank.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        //xAngle = 0.0f;
        //yAngle = 0.5f;
       // zAngle = 0.0f;

       // Tank.transform.position = new Vector3(0.5f, 0f, 0f);
        //xAngle = 0.5f;
        //Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        float rotateTank = Input.GetAxis("Horizontal");
        float moveTank = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = transform.forward * movespeed * moveTank;

        transform.Rotate(Vector3.up * rotationSpeed * rotateTank * Time.deltaTime);
        //Tank.transform.Rotate(xAngle, yAngle, zAngle);
    }
}
