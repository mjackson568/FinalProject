using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Rigidbody Shell;
    float fireElapsedTime = 0.0f;
    public Transform FireStart;
    public float fireDelay = 0.3f;

    private Transform Allturrets;
    // Start is called before the first frame update
    void Start()
    {
        Allturrets = FireStart.parent;


    }

    public void Shoot()
    {
        Rigidbody rbShell = Instantiate(Shell, FireStart.position, Allturrets.rotation);

        rbShell.velocity = 20.0f * Allturrets.forward;
    }
    // Update is called once per frame
    void Update()
    {
        fireElapsedTime += Time.deltaTime;
        if (Input.GetKey(KeyCode.Mouse0) && fireElapsedTime >= fireDelay)
        {
            Shoot();
            fireElapsedTime = 0;
        }
    }
}
