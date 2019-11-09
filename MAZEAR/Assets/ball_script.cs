using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball_script : MonoBehaviour
{

    public GameObject Plane;
    public GameObject SpawnPoint;
    public Rigidbody Sphere;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > Plane.transform.position.z + 5)
        {
            transform.position = SpawnPoint.transform.position;
            Sphere.velocity = Vector3.zero;
            Sphere.angularVelocity = Vector3.zero;
        }
       
    }

    // If level Completed : rigidbody.Sleep();
}
