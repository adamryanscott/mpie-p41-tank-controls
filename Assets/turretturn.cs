using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretturn : MonoBehaviour
{
    public float turretspeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = gameObject.transform;
       
        if (Input.GetKey(KeyCode.Q))
        {
            float turnspeed = turretspeed * Time.deltaTime;
            t.Rotate(0.0f, turnspeed, 0.0f);
        }

        if (Input.GetKey(KeyCode.E))
        {
            float turnspeed = -turretspeed * Time.deltaTime;
            t.Rotate(0.0f, turnspeed, 0.0f);
        }

       
    }
}
