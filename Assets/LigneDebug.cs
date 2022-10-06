using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigneDebug : MonoBehaviour
{

    public Transform cible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 depart = transform.position;
        Vector3 arrive = cible.position;
        Vector3 rayon = arrive - depart;
        Vector3 rayon_perpendiculaire = new Vector3(rayon.y, -rayon.x, 0.0f); // Pour faire le perpendiculaire
        Vector3 rayon_normalized = rayon_perpendiculaire.normalized;
        float longueur_de_t = 0.50f;

        // Color color = new Color(q, q, 1.0f); // de 0 a 1
        Color color = Color.magenta;
        Color color2 = Color.cyan;
        Debug.DrawLine(depart, arrive, color, 1.0f); // origin, drawline, couleur, second


        Debug.DrawRay(depart, rayon_perpendiculaire*longueur_de_t, color2, 2.0f);
        Debug.DrawRay(depart, -rayon_perpendiculaire* longueur_de_t, color2, 2.0f);
    }
}
