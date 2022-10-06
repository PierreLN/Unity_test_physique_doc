using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementRigidBody : MonoBehaviour
{
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rig.position = rig.position + new Vector2(3.0f * Time.fixedDeltaTime, -0.005f);
    }
}
