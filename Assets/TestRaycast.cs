using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRaycast : MonoBehaviour
{
    public Transform cible;
    private SpriteRenderer rendu;
    public float maxDistance = 5.0f;

    public LayerMask masqueRayon; // pour interagir sur certain layer

    // Start is called before the first frame update
    void Start()
    {
        rendu = GetComponent<SpriteRenderer>(); // prend le premier des renderers
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rayon = cible.position - transform.position;
        rayon.Normalize();


         

        Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), rayon, maxDistance); // vecteur 2D
        // possible de juste utiliser transform.position, il va ignorer le Z

        RaycastHit2D hit = Physics2D.Raycast(transform.position, rayon, maxDistance, masqueRayon);

        if (hit.collider != null) // pour retirer les contacts avec environements
        {
            Debug.DrawLine(transform.position, hit.point);
            rendu.color = Color.blue;
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Acteur"))
            {
                rendu.color = Color.red;

            }
        }
        else
        {
            Debug.DrawRay(transform.position, rayon * maxDistance);
            rendu.color = Color.blue;
        }
    }
}
