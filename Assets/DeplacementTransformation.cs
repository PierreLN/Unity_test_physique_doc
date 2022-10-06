using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementTransformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        transform.position = (transform.position + new Vector3(3.0f * Time.fixedDeltaTime, -0.005f, 0.0f));
    }
}
