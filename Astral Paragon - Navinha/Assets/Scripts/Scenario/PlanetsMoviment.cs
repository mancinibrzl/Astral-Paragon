using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetsMoviment : MonoBehaviour
{
    public float planetSpeed;

    private void Update()
    {
        PlanetMoviment();    
    }

    private void PlanetMoviment()
    {
        transform.Translate(Vector3.down * planetSpeed * Time.deltaTime);
    }
}
