using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulsion : MonoBehaviour
{
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.AddForce(new Vector2(5.0f, 0.0f), ForceMode2D.Impulse); // affecté par la masse
    }

    // Update is called once per frame
    void Update()
    {

    }


}
