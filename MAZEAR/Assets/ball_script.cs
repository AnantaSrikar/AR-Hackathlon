using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ball_script : MonoBehaviour
{

    public GameObject Plane;
    public GameObject SpawnPoint;
    public Rigidbody Sphere;
    public string sceneName;
    

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
            LoadLevel(sceneName);

        }
       
    }

    public void LoadLevel(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

    // If level Completed : rigidbody.Sleep();
}
