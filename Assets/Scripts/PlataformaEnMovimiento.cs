using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaEnMovimiento : MonoBehaviour
{
    public GameObject[] wayPoints;
    public float plataformaVelocidad = 2f;
    private int wayPointsIndex = 0;

    // Update is called once per frame
    void Update()
    {
        MovimientoDePlataforma();
    }

    void MovimientoDePlataforma()
    {
        if (Vector3.Distance(transform.position, wayPoints[wayPointsIndex].transform.position) < 0.1f)
        {
            wayPointsIndex++;
            if (wayPointsIndex >= wayPoints.Length)
            {
                wayPointsIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, wayPoints[wayPointsIndex].transform.position, plataformaVelocidad * Time.deltaTime);
    }
}
