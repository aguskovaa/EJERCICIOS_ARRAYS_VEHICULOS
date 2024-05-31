using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;


    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ElimininarAutos();
            vehiculos[Random.Range(0, vehiculos.Length)].SetActive(true);
        }   
    }

    void ResetearVehiculos()
    {
        ElimininarAutos();
        vehiculos[0].SetActive(true);
    }
    void ElimininarAutos()
    {
        foreach (GameObject g in vehiculos)
        {
            g.SetActive(false);
        }
    }
}
