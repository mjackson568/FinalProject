using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(IP_Tank_Inputs))]




public class Turretscript : MonoBehaviour
{
    

    [Header("Reticle Properties")]
    public Transform reticleTransform;
    [Header("Turret Properties")]
    public Transform turretTransform;
    public float turretLagSpeed = 0.5f;



    private Rigidbody rb;
    private IP_Tank_Inputs input;
    private Vector3 finalTurretLookDir;
 

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        input = GetComponent<IP_Tank_Inputs>();
    }

    void FixedUpdate()
    {
        if (rb && input)
        {
            HandleReticle();
            HandleTurret();
        }
    }





    protected virtual void HandleTurret()
    {
        if (turretTransform)
        {
            Vector3 turretLookDir = input.ReticlePosition - turretTransform.position;
            turretLookDir.y = 0f;
            finalTurretLookDir = Vector3.Lerp(finalTurretLookDir, turretLookDir, Time.deltaTime * turretLagSpeed);
            turretTransform.rotation = Quaternion.LookRotation(turretLookDir);
        }
    }




    protected virtual void HandleReticle()
    {
        if (reticleTransform)
        {
            reticleTransform.position = input.ReticlePosition;
        }


    }

}


